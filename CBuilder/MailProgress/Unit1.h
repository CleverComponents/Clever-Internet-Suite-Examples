//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clMailMessage.hpp>
#include <clMC.hpp>
#include <clPop3.hpp>
#include <clSmtp.hpp>
#include <clTcpClient.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include "clTcpClientTls.hpp"
#include "clTcpCommandClient.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TEdit *edtServer;
  TEdit *edtUser;
  TEdit *edtPassword;
  TButton *btnSend;
  TButton *btnReceive;
  TclPop3 *clPOP31;
  TclSmtp *clSMTP1;
  TclMailMessage *clMailMessage1;
  TProgressBar *ProgressBar1;
  TLabel *Label4;
  TLabel *Label5;
  TEdit *edtFrom;
  TEdit *edtTo;
  TLabel *lblProgress;
  TButton *btnStop;
  TEdit *edtAttachment;
  TLabel *Label6;
  TButton *btnBrowse;
  TOpenDialog *OpenDialog1;
  TLabel *Message;
  TMemo *memBody;
  void __fastcall btnSendClick(TObject *Sender);
  void __fastcall btnReceiveClick(TObject *Sender);
  void __fastcall btnStopClick(TObject *Sender);
  void __fastcall btnBrowseClick(TObject *Sender);
        void __fastcall clMailProgress(TObject *Sender,
          __int64 ABytesProceed, __int64 ATotalBytes);
	void __fastcall clMailMessage1SaveAttachment(TObject *Sender,
          TclAttachmentBody *ABody, UnicodeString &AFileName, TStream *&AData,
          bool &Handled);
	void __fastcall clMailMessage1EncodingProgress(TObject *Sender,
          TclMessageBody *ABody, __int64 ABytesProceed, __int64 ATotalBytes);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
