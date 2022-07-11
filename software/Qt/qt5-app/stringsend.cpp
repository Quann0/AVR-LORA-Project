#include "stringsend.h"
#include "ui_stringsend.h"
#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "console.h"
#include <QDebug>
#include <QMainWindow>
StringSend::StringSend(QWidget *parent) :
  QDialog(parent),
  ui(new Ui::StringSend)

{
  ui->setupUi(this);
}

StringSend::~StringSend()
{
  delete ui;
}

void StringSend::on_buttonBox_clicked(QAbstractButton *button)
{
  Q_UNUSED(button);
  QString data = ui->textEdit->toPlainText();
  QByteArray boxsend = data.toLocal8Bit();
  MainWindow a;
  a.m_serial->write(boxsend+'\n');
}

