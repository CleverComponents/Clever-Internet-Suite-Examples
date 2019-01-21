//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clCertificate.hpp>
#include <ComCtrls.hpp>
#include <clCertificateStore.hpp>
#include "createfrm.h"
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TLabel *Label1;
  TComboBox *cbLocation;
  TLabel *Label2;
  TComboBox *cbName;
  TButton *btnLoad;
  TButton *btnExport;
  TButton *btnImport;
  TButton *btnDelete;
  TButton *btnCreateSelfSigned;
  TButton *btnClose;
  TListView *lvCertificates;
  TLabel *Label3;
  TclCertificateStore *clCertificateStore1;
  TButton *btnCreateSigned;
  TButton *btnSignRequest;
  TOpenDialog *OpenDialog1;
  void __fastcall btnLoadClick(TObject *Sender);
  void __fastcall btnCloseClick(TObject *Sender);
  void __fastcall btnExportClick(TObject *Sender);
  void __fastcall btnImportClick(TObject *Sender);
  void __fastcall btnDeleteClick(TObject *Sender);
  void __fastcall btnCreateSelfSignedClick(TObject *Sender);
  void __fastcall FormCreate(TObject *Sender);
  void __fastcall btnCreateSignedClick(TObject *Sender);
	void __fastcall btnSignRequestClick(TObject *Sender);
private:	// User declarations
  bool FIsOpened;
  void __fastcall CheckButtonsState();
  void __fastcall LoadCertificateList();
  void __fastcall InstallCerts();
  void __fastcall PrepareStore(TCreateCertForm *ADlg);
public:		// User declarations
  __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
