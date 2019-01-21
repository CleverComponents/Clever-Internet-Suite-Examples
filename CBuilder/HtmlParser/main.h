//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <clHtmlParser.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include "DemoBaseFormUnit.h"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TclDemoBaseForm
{
__published:	// IDE-managed Components
  TButton *btnOpen;
  TOpenDialog *OpenDialog;
  TclHtmlParser *clHtmlParser;
  TPageControl *PageControl;
  TTabSheet *tabLinks;
  TTabSheet *tabImages;
  TTabSheet *tabForms;
  TTabSheet *tabText;
  TListBox *lbLinks;
  TEdit *edtUrlHref;
  TEdit *edtUrlTarget;
  TEdit *edtUrlName;
  TLabel *Label1;
  TLabel *Label2;
  TLabel *Label3;
  TLabel *Label4;
  TLabel *Label5;
  TListBox *lbImages;
  TLabel *Label6;
  TLabel *Label7;
  TLabel *Label8;
  TLabel *Label9;
  TEdit *edtImageSrc;
  TEdit *edtImageWidth;
  TEdit *edtImageAlt;
  TEdit *edtImageHeight;
  TLabel *Label10;
  TListBox *lbForms;
  TLabel *Label11;
  TEdit *edtFormAction;
  TLabel *Label12;
  TEdit *edtFormEncType;
  TLabel *Label13;
  TEdit *edtFormName;
  TLabel *Label14;
  TEdit *edtFormMethod;
  TListBox *lbFormControls;
  TLabel *Label15;
  TRichEdit *lbText;
  void __fastcall btnOpenClick(TObject *Sender);
  void __fastcall lbLinksClick(TObject *Sender);
  void __fastcall lbImagesClick(TObject *Sender);
  void __fastcall lbFormsClick(TObject *Sender);
  void __fastcall clHtmlParserParseTag(TObject *Sender, TclHtmlTag *ATag);
private:	// User declarations
public:		// User declarations
  __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif
