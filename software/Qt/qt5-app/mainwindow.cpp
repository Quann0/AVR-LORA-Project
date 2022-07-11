/****************************************************************************
**
** Copyright (C) 2012 Denis Shienkov <denis.shienkov@gmail.com>
** Copyright (C) 2012 Laszlo Papp <lpapp@kde.org>
** Contact: https://www.qt.io/licensing/
**
** This file is part of the QtSerialPort module of the Qt Toolkit.
**
** $QT_BEGIN_LICENSE:BSD$
** Commercial License Usage
** Licensees holding valid commercial Qt licenses may use this file in
** accordance with the commercial license agreement provided with the
** Software or, alternatively, in accordance with the terms contained in
** a written agreement between you and The Qt Company. For licensing terms
** and conditions see https://www.qt.io/terms-conditions. For further
** information use the contact form at https://www.qt.io/contact-us.
**
** BSD License Usage
** Alternatively, you may use this file under the terms of the BSD license
** as follows:
**
** "Redistribution and use in source and binary forms, with or without
** modification, are permitted provided that the following conditions are
** met:
**   * Redistributions of source code must retain the above copyright
**     notice, this list of conditions and the following disclaimer.
**   * Redistributions in binary form must reproduce the above copyright
**     notice, this list of conditions and the following disclaimer in
**     the documentation and/or other materials provided with the
**     distribution.
**   * Neither the name of The Qt Company Ltd nor the names of its
**     contributors may be used to endorse or promote products derived
**     from this software without specific prior written permission.
**
**
** THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
** "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
** LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
** A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
** OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
** SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
** LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
** DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
** THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
** (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
** OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE."
**
** $QT_END_LICENSE$
**
****************************************************************************/

#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "console.h"
#include "settingsdialog.h"
#include "plotdialog.h"
#include "stringsend.h"
#include <QDebug>
#include <QLabel>
#include <QMessageBox>
#define _DEBUG_
//! [0]
MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    m_ui(new Ui::MainWindow),
    m_status(new QLabel),
    m_console(new Console),
    m_settings(new SettingsDialog),
    m_plot(new plotDialog),
//! [1]
    m_serial(new QSerialPort(this))
//! [1]
{
//! [0]
    m_ui->setupUi(this);
    m_console->setEnabled(false);
    setCentralWidget(m_console);

    m_ui->actionConnect->setEnabled(true);
    m_ui->actionDisconnect->setEnabled(false);
    m_ui->actionQuit->setEnabled(true);
    m_ui->actionConfigure->setEnabled(true);

    m_ui->statusBar->addWidget(m_status);

    initActionsConnections();

    connect(m_serial, &QSerialPort::errorOccurred, this, &MainWindow::handleError);

//! [2]
    connect(m_serial, &QSerialPort::readyRead, this, &MainWindow::readData);
//! [2]
    connect(m_console, &Console::getData, this, &MainWindow::writeData);
//! [3]
}
//! [3]

MainWindow::~MainWindow()
{
    delete m_settings;
    delete m_ui;
}

//! [4]
/****************************************************************
 * Function Name : openSerialPort
 * Description   : Open Serial port with selected params
 * Returns       : None
 * Params        : None
 ****************************************************************/
void MainWindow::openSerialPort()
{
    const SettingsDialog::Settings p = m_settings->settings();
    m_serial->setPortName(p.name);
    m_serial->setBaudRate(p.baudRate);
    m_serial->setDataBits(p.dataBits);
    m_serial->setParity(p.parity);
    m_serial->setStopBits(p.stopBits);
    m_serial->setFlowControl(p.flowControl);
    if (m_serial->open(QIODevice::ReadWrite)) {
        m_console->setEnabled(true);
        m_console->setLocalEchoEnabled(p.localEchoEnabled);
        m_ui->actionConnect->setEnabled(false);
        m_ui->actionDisconnect->setEnabled(true);
        m_ui->actionConfigure->setEnabled(false);
        showStatusMessage(tr("Connected to %1 : %2, %3, %4, %5, %6")
                          .arg(p.name).arg(p.stringBaudRate).arg(p.stringDataBits)
                          .arg(p.stringParity).arg(p.stringStopBits).arg(p.stringFlowControl));
    } else {
        QMessageBox::critical(this, tr("Error"), m_serial->errorString());

        showStatusMessage(tr("Open error"));
    }
}
//! [4]

//! [5]
/****************************************************************
 * Function Name : closeSerialPort
 * Description   : Close opened Serial port
 * Returns       : None
 * Params        : None
 ****************************************************************/
void MainWindow::closeSerialPort()
{
    if (m_serial->isOpen())
        m_serial->close();
    m_console->setEnabled(false);
    m_ui->actionConnect->setEnabled(true);
    m_ui->actionDisconnect->setEnabled(false);
    m_ui->actionConfigure->setEnabled(true);
    showStatusMessage(tr("Disconnected"));
}
//! [5]

void MainWindow::about()
{
    QMessageBox::about(this, tr("About Simple Terminal"),
                       tr("The <b>Simple Terminal</b> example demonstrates how to "
                          "use the Qt Serial Port module in modern GUI applications "
                          "using Qt, with a menu bar, toolbars, and a status bar."));
}

//! [6]
/****************************************************************
 * Function Name : writeData
 * Description   : Write data to the Serial port with inserted
 *               : data from console
 * Returns       : None
 * Params        : Data to be writen
 ****************************************************************/
void MainWindow::writeData(const QByteArray &data)
{
    m_serial->write(data);
}
//! [6]

//! [7]
/****************************************************************
 * Function Name : readData
 * Description   : Read data from the Serial port and display
 *               : data to the console
 * Returns       : None
 * Params        : None
 ****************************************************************/
void MainWindow::readData()
{
    QByteArray data1 = m_serial->readAll();
    char l_value_a[100] = {1};
    int l_positionOfComma_u32;
    dataInLine.append(data1);
#ifdef _DEBUG_
    qDebug() << "\n";
#endif
    //if(data.end() == "\n")
    if(data1.at(data1.length()-1) == '\n')
    {
        if(cout > 50)
        {
            x.erase(x.begin());
            y.erase(y.begin());
        }
        do
        {
            l_positionOfComma_u32= dataInLine.indexOf(',');
            strncpy_s(l_value_a,dataInLine.data(),l_positionOfComma_u32);
            x.append(cout); // x goes from -1 to 1
            y.append(atof(l_value_a));  // let's plot a quadratic function
            cout++;
            dataInLine.remove(0,l_positionOfComma_u32+1);
        }while(l_positionOfComma_u32 != -1);

        // Put data to plot data
        m_plot->SetData(x,y);
        dataInLine.clear();
    }
    QString a = "";
    for(int i=0;i<data1.length();i++){
        a+=QString::number((int)data1.data()[i]);;
      }
     QByteArray array = a.toLocal8Bit();
    char* buffer = array.data();
    QByteArray a1 = {buffer,2};
  QByteArray a2 = {buffer+2,1};
  QByteArray a3 = {buffer+3,2};
  QByteArray a4 = {buffer+5,1};
    m_console->putData("Temp: "+a1+","+a2+"ºC\n"+"Humi: "+a3+","+a4+"%\n\n");


//    }
}
//! [7]

//! [8]
void MainWindow::handleError(QSerialPort::SerialPortError error)
{
    if (error == QSerialPort::ResourceError) {
        QMessageBox::critical(this, tr("Critical Error"), m_serial->errorString());
        closeSerialPort();
    }
}
//! [8]
void MainWindow::Clear()
{
    x.clear();
    y.clear();
    cout = 0;
    m_plot->SetData(x,y);
    m_console->Console::clear();
}
void MainWindow::Exit()
{
    m_plot->close();
    m_settings->close();
    this->close();
}
void MainWindow::closeEvent (QCloseEvent *event)
{
//    QMessageBox::StandardButton resBtn = QMessageBox::question( this, "APP_NAME",
//                                                                tr("Are you sure?\n"),
//                                                                QMessageBox::Cancel | QMessageBox::No | QMessageBox::Yes,
//                                                                QMessageBox::Yes);
//    if (resBtn != QMessageBox::Yes) {
//        event->ignore();
//    } else {
    m_plot->close();
    m_settings->close();
    event->accept();
//    }
}
void MainWindow::initActionsConnections()
{
    connect(m_ui->actionConnect, &QAction::triggered, this, &MainWindow::openSerialPort);
    connect(m_ui->actionDisconnect, &QAction::triggered, this, &MainWindow::closeSerialPort);
    connect(m_ui->actionQuit, &QAction::triggered, this, &MainWindow::Exit);
    connect(m_ui->actionConfigure, &QAction::triggered, m_settings, &SettingsDialog::show);
    connect(m_ui->actionPlot, &QAction::triggered, m_plot, &plotDialog::show);
    connect(m_ui->actionClear, &QAction::triggered, this, &MainWindow::Clear);
    connect(m_ui->actionAbout, &QAction::triggered, this, &MainWindow::about);
    connect(m_ui->actionAboutQt, &QAction::triggered, qApp, &QApplication::aboutQt);
    connect(m_ui->actionBuz,&QAction::triggered,this,&MainWindow::Buz);
    connect(m_ui->actionLed,&QAction::triggered,this,&MainWindow::Led);
    connect(m_ui->actionSendString,&QAction::triggered,this,&MainWindow::String);
}

void MainWindow::showStatusMessage(const QString &message)
{
    m_status->setText(message);
}


void MainWindow::Buz()
{
  QString check = "BuzOn\n";
  if(m_serial->isOpen()){
     if(check == "BuzOn")
          m_serial->write("BuzOn\n");
     else
       {
          m_serial->write("BuzOff\n");
       }
    }
}
void MainWindow::Led()
{
  QString check = "LedOn\n";
  if(m_serial->isOpen()){
     if(check == "LedOn\n")
          m_serial->write("LedOn\n");
     else
       {
          m_serial->write("LedOff\n");
       }
    }
}
void MainWindow::String(){
  StringSend a;
  a.setModal(true);
  a.exec();
}
