#include <QApplication>
#include <QMainWindow>
#include <QVBoxLayout>
#include <QHBoxLayout>
#include <QLabel>
#include <QLineEdit>
#include <QComboBox>
#include <QPushButton>
#include <QMessageBox>


void validateCredentials(QLineEdit *userLineEdit, QLineEdit *passwordLineEdit, QMainWindow &window);
void switchToMainMenu(QMainWindow &window);

int main(int argc, char *argv[]) {
    QApplication app(argc, argv);

    QMainWindow window;
    window.setWindowTitle("Clínica XYZ");

   
    QVBoxLayout *loginLayout = new QVBoxLayout;
    QLabel *userLabel = new QLabel("Usuario:");
    QLineEdit *userLineEdit = new QLineEdit;
    QLabel *passwordLabel = new QLabel("Contraseña:");
    QLineEdit *passwordLineEdit = new QLineEdit;
    passwordLineEdit->setEchoMode(QLineEdit::Password);
    QPushButton *loginButton = new QPushButton("Iniciar sesión");

    
    QObject::connect(loginButton, &QPushButton::clicked, [&]() {
        validateCredentials(userLineEdit, passwordLineEdit, window);
    });

    loginLayout->addWidget(userLabel);
    loginLayout->addWidget(userLineEdit);
    loginLayout->addWidget(passwordLabel);
    loginLayout->addWidget(passwordLineEdit);
    loginLayout->addWidget(loginButton);

    
    QVBoxLayout *mainMenuLayout = new QVBoxLayout;
    QLabel *welcomeLabel = new QLabel("Bienvenido");
    QComboBox *mainMenuComboBox = new QComboBox;
    QPushButton *logoutButton = new QPushButton("Cerrar sesión");

    
    QObject::connect(logoutButton, &QPushButton::clicked, [&]() {
        window.centralWidget()->layout()->deleteLater(); 
        window.centralWidget()->setLayout(loginLayout);  
    });

    mainMenuLayout->addWidget(welcomeLabel);
    mainMenuLayout->addWidget(mainMenuComboBox);
    mainMenuLayout->addWidget(logoutButton);

    
    window.centralWidget()->setLayout(loginLayout);

    
    window.show();

    
    return app.exec();
}


void validateCredentials(QLineEdit *userLineEdit, QLineEdit *passwordLineEdit, QMainWindow &window) {
    QString username = userLineEdit->text();
    QString password = passwordLineEdit->text();

    
    if (username == "admin" && password == "admin") {
        switchToMainMenu(window);  
    } else {
        QMessageBox::critical(&window, "Error de inicio de sesión", "Usuario o contraseña incorrectos");
    }
}


void switchToMainMenu(QMainWindow &window) {
    QVBoxLayout *mainMenuLayout = new QVBoxLayout;
    QLabel *welcomeLabel = new QLabel("Bienvenido, Admin");
    QComboBox *mainMenuComboBox = new QComboBox;
    mainMenuComboBox->addItem("Gestión de Pacientes");
    mainMenuComboBox->addItem("Gestión de Doctores");
    mainMenuComboBox->addItem("Gestión de Farmacia");
    mainMenuComboBox->addItem("Gestión de Finanzas");
    QPushButton *logoutButton = new QPushButton("Cerrar sesión");

    
    QObject::connect(logoutButton, &QPushButton::clicked, [&]() {
        window.centralWidget()->layout()->deleteLater(); 
        window.centralWidget()->setLayout(loginLayout);  
    });

    mainMenuLayout->addWidget(welcomeLabel);
    mainMenuLayout->addWidget(mainMenuComboBox);
    mainMenuLayout->addWidget(logoutButton);

  
    window.centralWidget()->setLayout(mainMenuLayout);
}
