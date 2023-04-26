unit u1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, StdCtrls, ExtCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    txtDt: TEdit;
    Java: TCheckBox;
    Label4: TLabel;
    Pascal: TCheckBox;
    CLang: TCheckBox;
    Python: TCheckBox;
    Label3: TLabel;
    txtFm: TEdit;
    txtIm: TEdit;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    gr21: TRadioButton;
    gr22: TRadioButton;
    gr23: TRadioButton;
    gr24: TRadioButton;
    gr25: TRadioButton;
    txtotch: TEdit;
    procedure Button1Click(Sender: TObject);
    procedure JavaChange(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
var
  gruppa: string;
  lang: string;
begin
  if gr21.Checked then
    gruppa := '21ИС-21'
  else if gr22.Checked then
    gruppa := '22ИС-21'
  else if gr23.Checked then
    gruppa := '23ИС-21'
  else if gr24.Checked then
    gruppa := '24ИС-21'
  else if gr25.Checked then
    gruppa := '25ИС-21'
  else
    gruppa := 'Ошибка';
  lang := '';
  if pascal.Checked then
    lang := lang + ',Pascal';
  if clang.Checked then
    lang := lang + ',CLang';
  if Python.Checked then
    lang := lang + ',Python';
  if Java.Checked then
    lang := lang + ',Java';

  if lang = '' then
    lang := 'Отсутствует'
  else
    delete(lang,1,1);

  ShowMessage('Фамилия: ' + txtFm.Text + #13#10 + 'Имя: ' + txtIm.Text + #13#10
    + 'Отчество: ' + txtotch.Text + #13#10 + 'Дата рождения: ' + txtDt.Text + #13#10 + 'Группа: ' + gruppa + #13#10 + 'Язык программирования: '
    + lang );
end;

procedure TForm1.JavaChange(Sender: TObject);
begin

end;

end.

