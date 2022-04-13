//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include <clTcpClient.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clSFtp.hpp>
#include "clTcpClientSsh.hpp"
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
  TListBox *lbList;
  TLabel *Label7;
  TOpenDialog *OpenDialog;
  TSaveDialog *SaveDialog;
  TclSFtp *clSFtp1;
  void __fastcall btnLoginClick(TObject *Sender);
  void __fastcall btnLogoutClick(TObject *Sender);
  void __fastcall btnOpenDirClick(TObject *Sender);
  void __fastcall btnGoUpClick(TObject *Sender);
  void __fastcall btnMakeDirClick(TObject *Sender);
  void __fastcall btnRemoveDirClick(TObject *Sender);
  void __fastcall btnDeleteFileClick(TObject *Sender);
  void __fastcall btnRenameClick(TObject *Sender);
  void __fastcall btnDownloadClick(TObject *Sender);
  void __fastcall btnUploadClick(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall clSFtp1DirectoryListing(TObject *Sender,
          const UnicodeString AFileName, TclSFtpFileAttrs *AFileAttrs);
  void __fastcall clSFtp1Progress(TObject *Sender, __int64 ABytesProceed,
          __int64 ATotalBytes);
  void __fastcall clSFtp1ReceiveResponse(TObject *Sender, int AFxpCommand,
          TStream *ABuffer);
  void __fastcall clSFtp1SendCommand(TObject *Sender, int AFxpCommand,
          TStream *ABuffer);
  void __fastcall clSFtp1ShowBanner(TObject *Sender, const UnicodeString AMessage,
          const UnicodeString ALanguage);
	void __fastcall FormShow(TObject *Sender);
	void __fastcall clSFtp1VerifyServer(TObject *Sender, const UnicodeString AHost,
          const UnicodeString AKeyType, const UnicodeString AFingerPrint,
          const UnicodeString AHostKey, bool &AVerified);

private:	// User declarations
  int __fastcall GetProgressBarPos(__int64 APosition, __int64 ASize);
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
