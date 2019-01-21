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
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clTcpClient.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label3;
  TMemo *memLog;
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
  TButton *btnMakeDir;
  TButton *btnRemoveDir;
  TButton *btnDownload;
  TButton *btnUpload;
  TButton *btnDeleteFile;
  TButton *btnRename;
  TButton *btnAbort;
  TListBox *lbList;
  TLabel *Label7;
  TclFtp *clFTP;
  TOpenDialog *OpenDialog;
  TSaveDialog *SaveDialog;
  void __fastcall btnLoginClick(TObject *Sender);
  void __fastcall btnLogoutClick(TObject *Sender);
  void __fastcall btnOpenDirClick(TObject *Sender);
  void __fastcall btnGoUpClick(TObject *Sender);
  void __fastcall btnMakeDirClick(TObject *Sender);
  void __fastcall btnRemoveDirClick(TObject *Sender);
  void __fastcall btnDeleteFileClick(TObject *Sender);
  void __fastcall btnRenameClick(TObject *Sender);
  void __fastcall btnAbortClick(TObject *Sender);
  void __fastcall btnDownloadClick(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall clFTPDirectoryListing(TObject *Sender,
          TclFtpFileInfo *AFileInfo, const UnicodeString Source);
  void __fastcall clFTPReceiveResponse(TObject *Sender, TStrings *AList);
  void __fastcall clFTPSendCommand(TObject *Sender,
          const UnicodeString AText);
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
