//---------------------------------------------------------------------------

#include <vcl.h>
#include <stdio.h>
#include <clEncoder.hpp>
#pragma hdrstop

//---------------------------------------------------------------------------

TclEncodeMethod GetMethod(const UnicodeString AMethod)
{
  if((AMethod == "QP") || (AMethod == "Q"))
    return cmQuotedPrintable;
  if((AMethod == "BASE64") || (AMethod == "B"))
    return cmBase64;
  if((AMethod == "UUE") || (AMethod == "U"))
    return cmUUEncode;
  return cmNone;
}

#pragma argsused
int main(int argc, char* argv[])
{
  if(argc < 4)
  {
	printf("This console app encodes / decodes files in Base64, Quoted-Printable, and UUEncode formats.\n");
	printf("Usage: Encoder.exe srcfile destfile operation[E][D] method[QP][BASE64][UUE]\n");
	printf("Press Enter to continue...");
	getchar();
    return 0;
  }
  TclEncoder *Encoder = NULL;
  TStream *Src = NULL, *Dst = NULL;
  __try
  {
    Encoder = new TclEncoder(NULL);
    Src = new TFileStream(argv[1], fmOpenRead);
    Dst = new TFileStream(argv[2], fmCreate);

    Encoder->EncodeMethod = GetMethod(argv[4]);
    UnicodeString s = argv[3];
    if(s == "E")
      Encoder->Encode(Src, Dst);
    else
      Encoder->Decode(Src, Dst);
    printf("Done.");
  }
  __finally
  {
    delete Dst;
    delete Src;
    delete Encoder;
  }
  return 0;
}
//---------------------------------------------------------------------------
 
