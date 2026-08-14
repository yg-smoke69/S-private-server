using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040BC")]
public class ResUnzipFileLoader : ResFileLoader, _Attribute
{
	[Token(Token = "0x401B30C")]
	[FieldOffset(Offset = "0x2C")]
	public string OutputPath;

	[Token(Token = "0x401B30D")]
	[FieldOffset(Offset = "0x30")]
	public Action<string, ResUnzipFileLoader> OnLoaded;

	[Token(Token = "0x401B30E")]
	[FieldOffset(Offset = "0x34")]
	public int BufferSize;

	[Token(Token = "0x401B30F")]
	[FieldOffset(Offset = "0x38")]
	private GZipInputStream m_GZipStream;

	[Token(Token = "0x401B310")]
	[FieldOffset(Offset = "0x3C")]
	private FileStream m_OutputStream;

	[Token(Token = "0x401B311")]
	[FieldOffset(Offset = "0x40")]
	private long m_SizeUnzipped;

	[Token(Token = "0x401B312")]
	[FieldOffset(Offset = "0x48")]
	private byte[] m_Buffer;

	[Token(Token = "0x401B313")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsFinished;

	[Token(Token = "0x401B314")]
	[FieldOffset(Offset = "0x50")]
	private SHA1CryptoServiceProvider m_HashWorker;

	[Token(Token = "0x601A581")]
	[Address(RVA = "0x32EC43C", Offset = "0x32EC43C", VA = "0x32EC43C")]
	public ResUnzipFileLoader()
	{
	}

	[Token(Token = "0x601A582")]
	[Address(RVA = "0x32EC4E4", Offset = "0x32EC4E4", VA = "0x32EC4E4", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A583")]
	[Address(RVA = "0x32EC7C0", Offset = "0x32EC7C0", VA = "0x32EC7C0", Slot = "10")]
	public override bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A584")]
	[Address(RVA = "0x32EC7D0", Offset = "0x32EC7D0", VA = "0x32EC7D0", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A585")]
	[Address(RVA = "0x32EC7D8", Offset = "0x32EC7D8", VA = "0x32EC7D8", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A586")]
	[Address(RVA = "0x32ECEEC", Offset = "0x32ECEEC", VA = "0x32ECEEC", Slot = "12")]
	protected override void OnUpdateInThread(float time)
	{
	}

	[Token(Token = "0x601A587")]
	[Address(RVA = "0x32ECEFC", Offset = "0x32ECEFC", VA = "0x32ECEFC", Slot = "9")]
	protected override void OnNotify()
	{
	}

	[Token(Token = "0x601A588")]
	[Address(RVA = "0x32ED0C4", Offset = "0x32ED0C4", VA = "0x32ED0C4", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A589")]
	[Address(RVA = "0x32ED1A8", Offset = "0x32ED1A8", VA = "0x32ED1A8", Slot = "5")]
	public override bool IsTimeout(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x601A58A")]
	[Address(RVA = "0x32ED148", Offset = "0x32ED148", VA = "0x32ED148")]
	public void CloseInput()
	{
	}

	[Token(Token = "0x601A58B")]
	[Address(RVA = "0x32ED090", Offset = "0x32ED090", VA = "0x32ED090")]
	private void CloseOutput()
	{
	}

	[Token(Token = "0x601A58C")]
	[Address(RVA = "0x32ED17C", Offset = "0x32ED17C", VA = "0x32ED17C")]
	private void ClearHashWorker()
	{
	}

	[Token(Token = "0x601A58D")]
	[Address(RVA = "0x32ED1B0", Offset = "0x32ED1B0", VA = "0x32ED1B0", Slot = "16")]
	public ResFileLoader CopyToBackGroundLoader()
	{
		return null;
	}
}
