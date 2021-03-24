unit udm;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, db, IBDatabase, IBTable, IBCustomDataSet, IBQuery, StdCtrls;

type

  { Tdm }

  Tdm = class(TDataModule)
    DataSource1: TDataSource;
    dtsfilm: TDataSource;
    dtsTimetable: TDataSource;
    dtsWorkers: TDataSource;
    ibdb: TIBDatabase;
    ibfilmDURATION: TTimeField;
    ibfilmGENRE: TIBStringField;
    ibfilmNAME: TIBStringField;
    ibkdmAMOUNT: TIBIntegerField;
    ibkdmID: TIBIntegerField;
    ibkdmID_FILM_PROJECTOR: TIBIntegerField;
    ibkdmNAME: TIBStringField;
    ibkdmTIME: TTimeField;
    ibkdm: TIBTable;
    ibqKDMID: TIBIntegerField;
    ibqKDMID_FILM_PROJECTOR: TIBIntegerField;
    ibqKDMNAMBER: TIBIntegerField;
    ibqKDMNAME: TIBStringField;
    ibqKDMSEAT: TIBIntegerField;
    ibfilm: TIBTable;
    ibTimetable: TIBTable;
    IBTable1AMOUNT: TIBIntegerField;
    IBTable1ID: TIBIntegerField;
    IBTable1ID_FILM_PROJECTOR: TIBIntegerField;
    IBTable1NAME: TIBStringField;
    IBTable1TIME: TTimeField;
    ibTimetableNAMBER: TIBIntegerField;
    ibTimetableNAME: TIBStringField;
    ibTimetableSESSION_TIME: TTimeField;
    ibWorkers: TIBTable;
    ibtr: TIBTransaction;
    ibWorkersID: TIBIntegerField;
    ibWorkersNAME: TIBStringField;
    ibWorkersPAY: TIBBCDField;
    ibWorkersPOST: TIBStringField;
    procedure DataModuleCreate(Sender: TObject);
    procedure DataSource1DataChange(Sender: TObject; Field: TField);
    procedure dtsKDMDataChange(Sender: TObject; Field: TField);
    procedure dtsTimetableDataChange(Sender: TObject; Field: TField);
    procedure dtsWorkersDataChange(Sender: TObject; Field: TField);
  private

  public
    skladIndexes:TstringList;
    procedure LoadTable(tableName:string;strl:TstringList;cmd:Tcombobox);

  end;

var
  dm: Tdm;

implementation

{$R *.lfm}

{ Tdm }

procedure Tdm.DataModuleCreate(Sender: TObject);
begin
  ibtr.StartTransaction;
  ibWorkers.Open;
  ibTimetable.Open;
  //ibqKDM.Open;
  ibkdm.Open;
  ibfilm.Open;
//  KMDIndexes:=TstringList.Create;
 // LoadTable('KDM_key',nil,FMain.cmbkdm);
end;

procedure Tdm.DataSource1DataChange(Sender: TObject; Field: TField);
begin

end;

procedure Tdm.dtsKDMDataChange(Sender: TObject; Field: TField);
begin

end;

procedure Tdm.dtsTimetableDataChange(Sender: TObject; Field: TField);
begin

end;

procedure Tdm.dtsWorkersDataChange(Sender: TObject; Field: TField);
begin

end;

procedure Tdm.LoadTable(tableName: string; strl: TstringList; cmd: Tcombobox);
begin {
  ibq.Close;
  if not(ibq.Transaction.Active) then ibq.Transaction.StartTransaction;
  ibq.sql.Text:='select * from '+tableName;
  ibq.Open;
  while not(ibq.EOF) do
  begin
    //cmb.Items.Add(ibq.FieldByName('NAME').AsString);
    ibq.Next;
  end; }
end;

end.

