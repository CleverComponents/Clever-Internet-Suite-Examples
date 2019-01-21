//---------------------------------------------------------------------------

#ifndef certlistfrmH
#define certlistfrmH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clCertificateStore.hpp>
//---------------------------------------------------------------------------
class TCertListForm : public TForm
{
__published:	// IDE-managed Components
  TListBox *lbList;
  TButton *btnInstall;
  TButton *btnClose;
  void __fastcall btnInstallClick(TObject *Sender);
  void __fastcall btnCloseClick(TObject *Sender);
private:	// User declarations
  TclCertificateStore *FCertificates;
  void __fastcall FillList();
public:		// User declarations
  __fastcall TCertListForm(TComponent* Owner);
  static void __fastcall ShowCertificates(TclCertificateStore *AList);
};
//---------------------------------------------------------------------------
extern PACKAGE TCertListForm *CertListForm;
//---------------------------------------------------------------------------
#endif
