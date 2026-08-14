using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040BD")]
public class ResHashFileLoader : ResFileLoader
{
	[Token(Token = "0x401B315")]
	[FieldOffset(Offset = "0x2C")]
	public Action<string, ResHashFileLoader> OnLoaded;

	[Token(Token = "0x401B316")]
	[FieldOffset(Offset = "0x30")]
	private FileStream m_FileStream;

	[Token(Token = "0x401B317")]
	[FieldOffset(Offset = "0x38")]
	private long m_SizeHashed;

	[Token(Token = "0x401B318")]
	[FieldOffset(Offset = "0x40")]
	private byte[] m_Buffer;

	[Token(Token = "0x401B319")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsFinished;

	[Token(Token = "0x401B31A")]
	[FieldOffset(Offset = "0x48")]
	private SHA1CryptoServiceProvider m_HashWorker;

	[Token(Token = "0x601A58E")]
	[Address(RVA = "0x333B1B0", Offset = "0x333B1B0", VA = "0x333B1B0")]
	public ResHashFileLoader()
	{
	}

	[Token(Token = "0x601A58F")]
	[Address(RVA = "0x333B258", Offset = "0x333B258", VA = "0x333B258", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A590")]
	[Address(RVA = "0x333B4B4", Offset = "0x333B4B4", VA = "0x333B4B4", Slot = "10")]
	public override bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A591")]
	[Address(RVA = "0x333B4C4", Offset = "0x333B4C4", VA = "0x333B4C4", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A592")]
	[Address(RVA = "0x333B4CC", Offset = "0x333B4CC", VA = "0x333B4CC", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A593")]
	[Address(RVA = "0x333BB88", Offset = "0x333BB88", VA = "0x333BB88", Slot = "9")]
	protected override void OnNotify()
	{
	}

	[Token(Token = "0x601A594")]
	[Address(RVA = "0x333BCF0", Offset = "0x333BCF0", VA = "0x333BCF0", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A595")]
	[Address(RVA = "0x333BD80", Offset = "0x333BD80", VA = "0x333BD80", Slot = "5")]
	public override bool IsTimeout(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x601A596")]
	[Address(RVA = "0x333BD38", Offset = "0x333BD38", VA = "0x333BD38")]
	public void CloseInput()
	{
	}

	[Token(Token = "0x601A597")]
	[Address(RVA = "0x333BD54", Offset = "0x333BD54", VA = "0x333BD54")]
	private void ClearHashWorker()
	{
	}
}
