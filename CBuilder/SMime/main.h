//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clMailMessage.hpp>
#include <clSMimeMessage.hpp>
#include <clCertificateStore.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label3;
  TLabel *Label4;
  TMemo *memText;
  TMemo *memHtml;
  TLabel *Label5;
  TListBox *lbAttachments;
  TButton *btnAdd;
  TButton *btnClear;
  TButton *btnEncrypt;
  TButton *btnSign;
  TLabel *Label7;
  TLabel *Label8;
  TLabel *Label9;
  TEdit *edtFrom;
  TEdit *edtToList;
  TEdit *edtSubject;
  TOpenDialog *OpenDialog;
  TclSMimeMessage *clSMimeMessage;
  TSaveDialog *SaveDialog;
  TButton *btnSignEncrypt;
  TButton *btnVerify;
  TButton *btnVerifyDecrypt;
  TButton *btnDecrypt;
  TButton *btnNewMessage;
  TOpenDialog *OpenAttach;
  TCheckBox *cbDetachedSignature;
  TCheckBox *cbIncludeCertificate;
  TButton *btnViewCertificates;
  TclCertificateStore *clCertificateStore;
  TLabel *Label1;
  TLabel *Label2;
  void __fastcall btnAddClick(TObject *Sender);
  void __fastcall btnClearClick(TObject *Sender);
  void __fastcall btnEncryptClick(TObject *Sender);
  void __fastcall btnNewMessageClick(TObject *Sender);
  void __fastcall btnSignClick(TObject *Sender);
  void __fastcall btnSignEncryptClick(TObject *Sender);
  void __fastcall btnVerifyClick(TObject *Sender);
  void __fastcall btnDecryptClick(TObject *Sender);
  void __fastcall btnVerifyDecryptClick(TObject *Sender);
  void __fastcall cbDetachedSignatureClick(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall btnViewCertificatesClick(TObject *Sender);
	void __fastcall clSMimeMessageGetEncryptionCertificate(TObject *Sender,
          TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
          bool &Handled);
	void __fastcall clSMimeMessageGetSigningCertificate(TObject *Sender,
          TclCertificate *&ACertificate, TclCertificateList *AExtraCerts,
          bool &Handled);
	void __fastcall clSMimeMessageSaveAttachment(TObject *Sender,
          TclAttachmentBody *ABody, UnicodeString &AFileName, TStream *&AData,
          bool &Handled);
private:	// User declarations
  void __fastcall BuildMessage();
  void __fastcall FillControls();
  void __fastcall NewMessage();
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
