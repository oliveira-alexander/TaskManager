unit Entity.Task;

interface

uses
  Entity.Priority;


type
  TTask = class
    private
      FTitulo: string;
      FDescricao: string;
      FInicio: TDateTime;
      FTermino: TDateTime;
      FPrioridade: TPrioridade;

      constructor Create;
    public
      class function New: TTask;
      destructor Destroy; override;
  end;

implementation

uses
  System.SysUtils;


{ TTask }

constructor TTask.Create;
begin
  FTitulo := 'Título';
  FDescricao := 'Descrição';
  FInicio := Now;
  FTermino := Now;
end;

destructor TTask.Destroy;
begin
  inherited;
end;

class function TTask.New: TTask;
begin
  Result := Self.Create;
end;

end.
