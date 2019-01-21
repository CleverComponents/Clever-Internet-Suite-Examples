//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clFtp.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include <clTcpClient.hpp>
#include <ExtCtrls.hpp>
#include "DemoBaseFormUnit.h"
#include <Graphics.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TProgressBar *ProgressBar;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label4;
  TLabel *Label5;
  TLabel *Label6;
  TEdit *edtServer;
  TEdit *edtPort;
  TEdit *edtUser;
  TEdit *edtPassword;
  TEdit *edtStartDir;
  TCheckBox *cbPassiveMode;
  TCheckBox *cbAsciiMode;
  TButton *btnLogin;
  TButton *btnLogout;
  TButton *btnOpenDir;
  TButton *btnGoUp;
  TButton *btnDownload;
  TButton *btnUpload;
  TButton *btnAbort;
  TListBox *lbList;
  TLabel *Label7;
  TclFtp *clFTP;
  TOpenDialog *OpenDialog;
  TSaveDialog *SaveDialog;
  TBevel *Bevel1;
  TLabel *Label3;
  TLabel *Label8;
  TEdit *edtProxyServer;
  TEdit *edtProxyUser;
  TEdit *edtProxyPassword;
  TEdit *edtProxyPort;
  TLabel *Label9;
  TLabel *Label10;
  TLabel *Label11;
  TComboBox *cbProxyType;
  void __fastcall btnLoginClick(TObject *Sender);
  void __fastcall btnLogoutClick(TObject *Sender);
  void __fastcall btnOpenDirClick(TObject *Sender);
  void __fastcall btnGoUpClick(TObject *Sender);
  void __fastcall btnAbortClick(TObject *Sender);
  void __fastcall btnDownloadClick(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall clFTPDirectoryListing(TObject *Sender,
          TclFtpFileInfo *AFileInfo, const UnicodeString Source);
  void __fastcall FormDestroy(TObject *Sender);
        void __fastcall clFTPProgress(TObject *Sender,
          __int64 ABytesProceed, __int64 ATotalBytes);
	void __fastcall FormShow(TObject *Sender);
private:	// User declarations
  void __fastcall UpdateStatuses();
  void __fastcall DoOpenDir(const UnicodeString ADir);
  void __fastcall FillDirList();
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
