unit View.Main;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ComCtrls, Vcl.DBCGrids, Vcl.ExtCtrls,
  Vcl.Buttons, Controller.Main;

type
  TFrm_Main = class(TForm)
    Panel1: TPanel;
    Panel2: TPanel;
    Panel3: TPanel;
    pnlGrid: TPanel;
    dbgTasks: TDBCtrlGrid;
    Panel5: TPanel;
    calTasks: TMonthCalendar;
    pnlBotoes: TPanel;
    pnlBtnAdicionarTarefa: TPanel;
    Shape1: TShape;
    Panel8: TPanel;
    btnAddTask: TSpeedButton;
    procedure FormCreate(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
    FController: TControllerMain;

    procedure GetCurrentTasks;
  public
    { Public declarations }
  end;

var
  Frm_Main: TFrm_Main;

implementation

{$R *.dfm}

procedure TFrm_Main.FormCreate(Sender: TObject);
begin
  FController := TControllerMain.New;
end;

procedure TFrm_Main.FormShow(Sender: TObject);
begin
  calTasks.Date := Now;
  dbgTasks.DataSource := FController.DataSource;

  GetCurrentTasks;
end;

procedure TFrm_Main.GetCurrentTasks;
begin
  FController.GetCurrentTasks(calTasks.Date);
end;

end.
