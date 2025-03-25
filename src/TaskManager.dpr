program TaskManager;

uses
  Vcl.Forms,
  View.Main in 'Views\View.Main.pas' {Frm_Main},
  Entity.Task in 'Entities\Entity.Task.pas',
  Entity.Priority in 'Entities\Entity.Priority.pas',
  Service.Task in 'Services\Service.Task.pas',
  Controller.Main in 'Controllers\Controller.Main.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TFrm_Main, Frm_Main);
  Application.Run;
end.
