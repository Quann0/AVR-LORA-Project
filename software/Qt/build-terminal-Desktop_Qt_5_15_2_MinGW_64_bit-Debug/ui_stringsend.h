/********************************************************************************
** Form generated from reading UI file 'stringsend.ui'
**
** Created by: Qt User Interface Compiler version 5.15.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_STRINGSEND_H
#define UI_STRINGSEND_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QDialogButtonBox>
#include <QtWidgets/QTextEdit>

QT_BEGIN_NAMESPACE

class Ui_StringSend
{
public:
    QDialogButtonBox *buttonBox;
    QTextEdit *textEdit;

    void setupUi(QDialog *StringSend)
    {
        if (StringSend->objectName().isEmpty())
            StringSend->setObjectName(QString::fromUtf8("StringSend"));
        StringSend->resize(400, 107);
        buttonBox = new QDialogButtonBox(StringSend);
        buttonBox->setObjectName(QString::fromUtf8("buttonBox"));
        buttonBox->setGeometry(QRect(290, 20, 81, 241));
        buttonBox->setOrientation(Qt::Vertical);
        buttonBox->setStandardButtons(QDialogButtonBox::Cancel|QDialogButtonBox::Ok);
        textEdit = new QTextEdit(StringSend);
        textEdit->setObjectName(QString::fromUtf8("textEdit"));
        textEdit->setGeometry(QRect(50, 20, 221, 61));

        retranslateUi(StringSend);
        QObject::connect(buttonBox, SIGNAL(accepted()), StringSend, SLOT(accept()));
        QObject::connect(buttonBox, SIGNAL(rejected()), StringSend, SLOT(reject()));

        QMetaObject::connectSlotsByName(StringSend);
    } // setupUi

    void retranslateUi(QDialog *StringSend)
    {
        StringSend->setWindowTitle(QCoreApplication::translate("StringSend", "Dialog", nullptr));
#if QT_CONFIG(statustip)
        textEdit->setStatusTip(QString());
#endif // QT_CONFIG(statustip)
        textEdit->setHtml(QCoreApplication::translate("StringSend", "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n"
"<html><head><meta name=\"qrichtext\" content=\"1\" /><meta charset=\"utf-8\" /><style type=\"text/css\">\n"
"p, li { white-space: pre-wrap; }\n"
"</style></head><body style=\" font-family:'Segoe UI'; font-size:9pt; font-weight:400; font-style:normal;\">\n"
"<p style=\"-qt-paragraph-type:empty; margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><br /></p></body></html>", nullptr));
    } // retranslateUi

};

namespace Ui {
    class StringSend: public Ui_StringSend {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_STRINGSEND_H
