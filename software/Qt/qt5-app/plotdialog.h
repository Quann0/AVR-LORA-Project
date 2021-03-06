#ifndef PLOTDIALOG_H
#define PLOTDIALOG_H

#include <QDialog>

namespace Ui {
class plotDialog;
}

class plotDialog : public QDialog
{
    Q_OBJECT

public:
    explicit plotDialog(QWidget *parent = nullptr);
    void SetData(const QVector<double> &x, const QVector<double> &y);
    ~plotDialog();

private:
    void makePlot();

private:
    Ui::plotDialog *ui;
};

#endif // PLOTDIALOG_H
