unit Service.Task;

interface

type
  TServiceTask = class
    private
      constructor Create;
    public
      class function New: TServiceTask;
      destructor Destroy; override;
  end;

implementation

{ TServiceTask }

constructor TServiceTask.Create;
begin
end;

destructor TServiceTask.Destroy;
begin
  inherited;
end;

class function TServiceTask.New: TServiceTask;
begin
  Result := Self.Create;
end;

end.
