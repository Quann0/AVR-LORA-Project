#ifndef STRINGSEND_H
#define STRINGSEND_H
#include <QDialog>
#include <QAbstractButton>
namespace Ui {
  class StringSend;
}

class StringSend : public QDialog
{
  Q_OBJECT

public:
  explicit StringSend(QWidget *parent = nullptr);
  ~StringSend();

private slots:
  void on_buttonBox_clicked(QAbstractButton *button);

private:
  Ui::StringSend *ui;
};

#endif // STRINGSEND_H
