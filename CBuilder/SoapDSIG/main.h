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
#include <clHttpRequest.hpp>
#include <clSoapMessage.hpp>
#include <Dialogs.hpp>
#include <ExtCtrls.hpp>
#include <clCertificateStore.hpp>
#include "clSoapMessage.hpp"
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
    TclSoapMessage *clSoapMessage;
    TMemo *memSource;
    TMemo *memResult;
    TButton *btnSign;
    TLabel *Label1;
    TLabel *Label2;
    TEdit *edtCertFile;
    TEdit *edtCertPassword;
    TLabel *Label3;
    TMemo *memReferences;
    TButton *btnBrowse;
    TLabel *Label4;
    TLabel *Label5;
    TBevel *Bevel1;
    TOpenDialog *OpenDialog;
    TclCertificateStore *clCertificateStore;
  void __fastcall btnSignClick(TObject *Sender);
  void __fastcall btnBrowseClick(TObject *Sender);
	void __fastcall clSoapMessageGetSigningCertificate(TObject *Sender,
          TclXmlKeyInfo *AKeyInfo, TclCertificate *&ACertificate,
          TclCertificateList *AExtraCerts, bool &Handled);
private:	// User declarations
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
