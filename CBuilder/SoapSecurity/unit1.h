//---------------------------------------------------------------------------

#ifndef unit1H
#define unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <clCertificateStore.hpp>
#include <clHttpRequest.hpp>
#include <clSoapMessage.hpp>
#include <clXmlUtils.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
	TclSoapMessage *clSoapMessage1;
	TEdit *edtMethodURI;
	TLabel *Label2;
	TLabel *Label3;
	TEdit *edtMethod;
    TLabel *Label4;
    TMemo *memWSDLParams;
    TLabel *Label5;
    TMemo *memWSDLParamValues;
	TLabel *Label7;
    TEdit *edtBodyID;
    TLabel *Label8;
    TEdit *edtTimestampCreated;
    TLabel *Label9;
    TEdit *edtTimeStampExpires;
    TLabel *Label10;
    TEdit *edtTimeStampID;
	TGroupBox *GroupBox1;
	TGroupBox *GroupBox2;
	TGroupBox *GroupBox3;
	TLabel *Label12;
    TEdit *edtAddressName;
    TLabel *Label13;
    TEdit *edtAddressValue;
    TLabel *Label14;
    TEdit *edtAddressID;
    TLabel *Label15;
    TMemo *memSOAPMessage;
    TButton *btnSignEncrypt;
    TButton *btnDecryptVerify;
    TButton *btnCertificates;
    TclCertificateStore *clCertificateStore1;
    TOpenDialog *OpenDialog1;
    TSaveDialog *SaveDialog1;
  void __fastcall btnSignEncryptClick(TObject *Sender);
  void __fastcall btnDecryptVerifyClick(TObject *Sender);
  void __fastcall btnCertificatesClick(TObject *Sender);
  void __fastcall clSoapMessage1GetSigningCertificate(TObject *Sender,
          TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
          TclCertificateList *AExtraCerts, bool &Handled);
	void __fastcall clSoapMessage1GetEncryptionCertificate(TObject *Sender,
          TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
          TclCertificateList *AExtraCerts, UnicodeString &AStoreName,
          TclCertificateStoreLocation &AStoreLocation, bool &Handled);
private:	// User declarations
  bool FSecuring;
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
