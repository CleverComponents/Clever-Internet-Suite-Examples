program SimpleEncoder;

{$APPTYPE CONSOLE}

uses
  Windows, SysUtils, clEncoder, Classes;

function GetMethod(const AMethod: string): TclEncodeMethod;
begin
  if (AMethod = 'QP') or (AMethod = 'Q') then
  begin
    Result := cmQuotedPrintable;
  end else
  if (AMethod = 'BASE64') or (AMethod = 'B') then
  begin
    Result := cmBase64;
  end else
  if (AMethod = 'UUE') or (AMethod = 'U') then
  begin
    Result := cmUUEncode;
  end else
  begin
    Result := cmNone;
  end;
end;

var
  Encoder: TclEncoder;
  Src, Dst: TStream;
begin
  if ParamCount < 4 then
  begin
    WriteLn('This console app encodes / decodes files in Base64, Quoted-Printable, and UUEncode formats.');
    WriteLn('Usage: Encoder.exe srcfile destfile operation[E][D] method[QP][BASE64][UUE]');
    Exit;
  end;
  Encoder := nil;
  Src := nil;
  Dst := nil;
  try
    Encoder := TclEncoder.Create(nil);
    Src := TFileStream.Create(ParamStr(1), fmOpenRead);
    Dst := TFileStream.Create(ParamStr(2), fmCreate);
    Encoder.EncodeMethod := GetMethod(ParamStr(4));
    if (ParamStr(3) = 'E') then
      Encoder.Encode(Src, Dst)
    else
      Encoder.Decode(Src, Dst);
    WriteLn('Done.');
  finally
    Dst.Free();
    Src.Free();
    Encoder.Free();
  end;
end.
