using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040B9")]
public class ResWWWFileLoader : ResWithTimeoutFileLoader
{
	[Token(Token = "0x401B2FB")]
	[FieldOffset(Offset = "0x30")]
	public WWW HttpWWW;

	[Token(Token = "0x401B2FC")]
	[FieldOffset(Offset = "0x34")]
	public Action<WWW, ResWWWFileLoader> OnLoaded;

	[Token(Token = "0x401B2FD")]
	[FieldOffset(Offset = "0x38")]
	public ResDownloadType DownloadType;

	[Token(Token = "0x601A567")]
	[Address(RVA = "0x32EE444", Offset = "0x32EE444", VA = "0x32EE444")]
	public ResWWWFileLoader()
	{
	}

	[Token(Token = "0x601A568")]
	[Address(RVA = "0x33007A4", Offset = "0x33007A4", VA = "0x33007A4", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A569")]
	[Address(RVA = "0x330082C", Offset = "0x330082C", VA = "0x330082C", Slot = "10")]
	public override bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A56A")]
	[Address(RVA = "0x330083C", Offset = "0x330083C", VA = "0x330083C", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A56B")]
	[Address(RVA = "0x3300854", Offset = "0x3300854", VA = "0x3300854", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A56C")]
	[Address(RVA = "0x3300900", Offset = "0x3300900", VA = "0x3300900", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A56D")]
	[Address(RVA = "0x330092C", Offset = "0x330092C", VA = "0x330092C", Slot = "9")]
	protected override void OnNotify()
	{
	}
}
