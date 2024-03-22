from PyQt6 import QtWidgets, QtGui, QtCore
from PyQt6.QtCore import Qt, QByteArray
from PyQt6.QtGui import QImage, QPixmap
from FirstForm import * #это ui
# файл дизайнер
import MySQLdb as mdb

conn = mdb. connect('localhost', 'root', 'root', 'confectionery')
def get_data():
    cursor = conn.cursor()
    cursor.execute("CALL `GetAllChecksInfo`();")
    res = cursor.fetchall()
    return res

class MainWin(QtWidgets.QWidget, Ui_Form):
    def __init__(self, parent=None):
        super (MainWin, self).__init__(parent)
        self.setWindowIcon(QtGui.QIcon("BooksShops/img/qwr.png"))
        self.setupUi(self)
        res_data = get_data()
        print(res_data)
        height = 10
        for j in res_data:
            lb = QtWidgets.QLabel(self)
            lb.setText(f"{j[0]},  {j[1]},  {j[2]},  {j[3]}")
            # for i in res_data:
            #     img = i[5]
            #     qimage = QImage. fromData(QByteArray(img))
            # # Создаем объект QРіхтар из QImage
            #     qpixmap = QPixmap.fromImage(qimage)
            # # Сохраняем QРіхтар в файл - jpg
            #     file_path = f"save_img/{i[0]}.jpg"
            #     qpixmap.save(file_path, "JPG")
            # # Поместить изображение в label
            #     lb = QtWidgets. QLabel(self)
            #     lb.setGeometry(QtCore.QRect(30, height, 180, 150))
            #     lb.setAlignment(Qt.AlignmentFlag.AlignCenter)
            #     lb.setText ("")
            #     lb.setPixmap(QtGui.QPixmap(f"save_img/{i[0]}.jpg"))
            #     lb.setObjectName(f" {i[0]}")
            #
            # # Поместить информацию в label
                 lb_t = QtWidgets.QLabel(self)
                 lb_t.setGeometry(QtCore.QRect(200, height, 210, 150))
                 lb_t.setAlignment(Qt.AlignmentFlag.AlignCenter)
                 lb_t.setText(f"{i[i]} \n {i[2]} {i[3]} \n {i[4]}")
                 lb_t.setObjectName(f"{i[0]}")
                 height += 120

if __name__ == "__main__":
    import sys
    app = QtWidgets. QApplication(sys.argv)
    wind = MainWin()
    wind.show()
    sys.exit(app.exec())