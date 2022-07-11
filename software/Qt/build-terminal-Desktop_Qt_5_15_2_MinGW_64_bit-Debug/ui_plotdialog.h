/********************************************************************************
** Form generated from reading UI file 'plotdialog.ui'
**
** Created by: Qt User Interface Compiler version 5.15.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_PLOTDIALOG_H
#define UI_PLOTDIALOG_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QVBoxLayout>
#include "qcustomplot.h"

QT_BEGIN_NAMESPACE

class Ui_plotDialog
{
public:
    QVBoxLayout *verticalLayout;
    QVBoxLayout *verticalLayout_2;
    QGroupBox *groupBox;
    QVBoxLayout *verticalLayout_4;
    QVBoxLayout *verticalLayout_3;
    QCustomPlot *customPlot;

    void setupUi(QDialog *plotDialog)
    {
        if (plotDialog->objectName().isEmpty())
            plotDialog->setObjectName(QString::fromUtf8("plotDialog"));
        plotDialog->resize(572, 373);
        plotDialog->setMinimumSize(QSize(572, 373));
        verticalLayout = new QVBoxLayout(plotDialog);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        verticalLayout_2 = new QVBoxLayout();
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        groupBox = new QGroupBox(plotDialog);
        groupBox->setObjectName(QString::fromUtf8("groupBox"));
        verticalLayout_4 = new QVBoxLayout(groupBox);
        verticalLayout_4->setObjectName(QString::fromUtf8("verticalLayout_4"));
        verticalLayout_3 = new QVBoxLayout();
        verticalLayout_3->setObjectName(QString::fromUtf8("verticalLayout_3"));
        customPlot = new QCustomPlot(groupBox);
        customPlot->setObjectName(QString::fromUtf8("customPlot"));

        verticalLayout_3->addWidget(customPlot);


        verticalLayout_4->addLayout(verticalLayout_3);


        verticalLayout_2->addWidget(groupBox);


        verticalLayout->addLayout(verticalLayout_2);


        retranslateUi(plotDialog);

        QMetaObject::connectSlotsByName(plotDialog);
    } // setupUi

    void retranslateUi(QDialog *plotDialog)
    {
        plotDialog->setWindowTitle(QCoreApplication::translate("plotDialog", "Dialog", nullptr));
        groupBox->setTitle(QCoreApplication::translate("plotDialog", "Plot Window", nullptr));
    } // retranslateUi

};

namespace Ui {
    class plotDialog: public Ui_plotDialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_PLOTDIALOG_H
