//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clMultiDC.hpp>
#include <clMultiUploader.hpp>
#include <ComCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TLabel *Label1;
    TLabel *Label2;
    TclMultiUploader *clMultiUploader;
    TLabel *Label3;
    TLabel *Label4;
    TEdit *edtLocalFolder;
    TEdit *edtFtpDir;
    TLabel *Label5;
    TLabel *Label6;
    TEdit *edtUser;
    TEdit *edtPassword;
    TCheckBox *cbPassiveMode;
    TButton *btnPublish;
    TButton *btnStop;
    TStatusBar *StatusBar1;
    TLabel *Label7;
    TMemo *memLog;
    TLabel *Label8;
    TEdit *edtFileMask;
  void __fastcall clMultiUploaderIsBusyChanged(TObject *Sender);
  void __fastcall clMultiUploaderProcessCompleted(TObject *Sender,
          TclInternetItem *Item);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
  void __fastcall btnPublishClick(TObject *Sender);
  void __fastcall clMultiUploaderPrepareItemToPublish(TObject *Sender,
          TclUploadItem *Item, bool &CanProceed, bool &Handled);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
