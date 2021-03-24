unit umain;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, db, Forms, Controls, Graphics, Dialogs, DBGrids, DBCtrls,
  Calendar, EditBtn, StdCtrls, DBExtCtrls, ExtDlgs, ComCtrls, PopupNotifier,
  ExtCtrls, Buttons, Menus, IBTable, VirtualTrees, DBDateTimePicker,
  DateTimePicker, RTTIGrids, RTTICtrls, Types;

type

  { TFMain }

  TFMain = class(TForm)
    DBGrid1: TDBGrid;
    DBGrid2: TDBGrid;
    DBGrid3: TDBGrid;
    DBGrid4: TDBGrid;
    DBNavigator1: TDBNavigator;
    DBNavigator2: TDBNavigator;
    DBNavigator3: TDBNavigator;
    DBNavigator4: TDBNavigator;
    movie: TPageControl;
    TabSheet1: TTabSheet;
    workers: TTabSheet;
    KDM_key: TTabSheet;
    timetable: TTabSheet;
    procedure cmbkdmChange(Sender: TObject);
    procedure DBComboBox1Change(Sender: TObject);
    procedure DBNavigator1Click(Sender: TObject; Button: TDBNavButtonType);
    procedure sdfsClick(Sender: TObject);
//    procedure movieChange(Sender: TObject);
    procedure KDM_keyContextPopup(Sender: TObject; MousePos: TPoint;
      var Handled: Boolean);
    //procedure movieChange(Sender: TObject);
    procedure TILabel1Click(Sender: TObject);
    procedure timetableContextPopup(Sender: TObject; MousePos: TPoint;
      var Handled: Boolean);
    procedure TIProgressBar1DragDrop(Sender, Source: TObject; X, Y: Integer);
    procedure workersContextPopup(Sender: TObject; MousePos: TPoint;
      var Handled: Boolean);
  private

  public

  end;

var
  FMain: TFMain;

implementation

{$R *.lfm}

{ TFMain }

procedure TFMain.DBNavigator1Click(Sender: TObject; Button: TDBNavButtonType);
begin
  end;

procedure TFMain.sdfsClick(Sender: TObject);
begin

end;

{procedure TFMain.movieChange(Sender: TObject);
begin

end; }

procedure TFMain.KDM_keyContextPopup(Sender: TObject; MousePos: TPoint;
  var Handled: Boolean);
begin

end;

{procedure TFMain.movieChange(Sender: TObject);
begin

end;  }

procedure TFMain.TILabel1Click(Sender: TObject);
begin

end;

procedure TFMain.timetableContextPopup(Sender: TObject; MousePos: TPoint;
  var Handled: Boolean);
begin

end;

procedure TFMain.TIProgressBar1DragDrop(Sender, Source: TObject; X, Y: Integer);
begin
  end;

procedure TFMain.workersContextPopup(Sender: TObject; MousePos: TPoint;
  var Handled: Boolean);
begin

end;

procedure TFMain.DBComboBox1Change(Sender: TObject);
begin

end;

procedure TFMain.cmbkdmChange(Sender: TObject);
begin

end;

end.

