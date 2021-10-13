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
#include <clSFtpServer.hpp>
#include <clTcpServer.hpp>
#include <clSFtpFileHandler.hpp>
#include <clServerGuard.hpp>
#include <clTcpServerSsh.hpp>
#include <clSshPacket.hpp>
#include <clSFtpUtils.hpp>
#include <clUtils.hpp>
#include <Vcl.ComCtrls.hpp>
#include <Vcl.Dialogs.hpp>

//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TclServerGuard *clServerGuard1;
  TclSFtpServer *clSFtpServer1;
  TclSFtpFileHandler *clSFtpFileHandler1;
  TPageControl *pgMain;
  TTabSheet *tabServer;
  TTabSheet *tabHostKey;
  TTabSheet *tabAccessControl;
  TTabSheet *tabIPBlocking;
  TTabSheet *tabSSHAlgorithms;
  TLabel *Label2;
  TEdit *edtPort;
  TLabel *Label3;
  TEdit *edtRootDir;
  TButton *btnStart;
  TButton *btnStop;
  TMemo *memLog;
  TLabel *Label1;
  TLabel *Label5;
  TEdit *edtBindingHost;
  TLabel *Label4;
  TTabSheet *tabBanner;
  TLabel *Label6;
  TEdit *edtAllowedConnections;
  TLabel *Label7;
  TMemo *memBlackList;
  TLabel *Label8;
  TMemo *memWhiteList;
  TCheckBox *cbWhiteListOnly;
  TLabel *Label9;
  TEdit *edtUserName;
  TLabel *Label10;
  TCheckBox *cbUseIPv6;
  TLabel *Label11;
  TEdit *edtPassword;
  TLabel *Label12;
  TEdit *edtUserRootDir;
  TGroupBox *gbUserPermissions;
  TCheckBox *cbCanList;
  TCheckBox *cbCanMakeDir;
  TCheckBox *cbCanRemoveDir;
  TCheckBox *cbCanRead;
  TCheckBox *cbCanWrite;
  TCheckBox *cbCanRename;
  TCheckBox *cbCanRemove;
  TCheckBox *cbCanMakeLink;
  TCheckBox *cbCanReadLink;
  TLabel *Label13;
  TLabel *Label14;
  TLabel *Label15;
  TEdit *edtBannerMessage;
  TLabel *Label16;
  TEdit *edtBannerLanguage;
  TCheckBox *cbEnableBanner;
  TLabel *Label17;
  TEdit *edtKeyType;
  TLabel *Label18;
  TEdit *edtKeyLength;
  TLabel *Label19;
  TEdit *edtHostKeyFile;
  TLabel *Label20;
  TEdit *edtFingerPrint;
  TButton *btnGenerateHostKey;
  TButton *btnLoadHostKey;
  TLabel *Label21;
  TLabel *Label22;
  TEdit *edtHostKeyPassPhrase;
  TLabel *Label23;
  TEdit *edtKexAlgs;
  TLabel *Label24;
  TEdit *edtSignatureAlgs;
  TLabel *Label25;
  TEdit *edtEncryptionAlgs;
  TLabel *Label26;
  TEdit *edtDataIntegrityAlgs;
  TLabel *Label27;
  TTabSheet *tabAdditional;
  TLabel *Label28;
  TEdit *edtCharSet;
  TLabel *Label29;
  TEdit *edtMaxReturnFiles;
  TLabel *Label30;
  TEdit *edtBatchSize;
  TLabel *Label31;
  TEdit *edtMaxWindowSize;
  TLabel *Label32;
  TLabel *lblStatus;
	TOpenDialog *OpenDialog1;
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall FormDestroy(TObject *Sender);
  void __fastcall btnStartClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnLoadHostKeyClick(TObject *Sender);
  void __fastcall btnGenerateHostKeyClick(TObject *Sender);
  void __fastcall clSFtpServer1AcceptConnection(TObject *Sender, TclUserConnection *AConnection,
          bool &Handled);
  void __fastcall clSFtpServer1CloseConnection(TObject *Sender, TclUserConnection *AConnection);
  void __fastcall clSFtpServer1ReceiveRequest(TObject *Sender, TclSFtpUserConnection *AConnection,
          BYTE ACommand, DWORD ARequestId, TclSshPacket *APacket);
  void __fastcall clSFtpServer1SendResponse(TObject *Sender, TclSFtpUserConnection *AConnection,
          BYTE ACommand, DWORD ARequestId, TclSshPacket *APacket);
  void __fastcall clSFtpServer1Start(TObject *Sender);
  void __fastcall clSFtpServer1Stop(TObject *Sender);



private:	// User declarations
  TCriticalSection *FSynchronizer;
  bool FIsStop;
  void __fastcall PutLogMessage(const UnicodeString ALogMessage);
  UnicodeString __fastcall GetCommandName(int AFxp);
  void __fastcall LoadHostKey();
  void __fastcall GenerateHostKey();
  void __fastcall AssignSettings();
  void __fastcall LoadDefaultSettings();
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
