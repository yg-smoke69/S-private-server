using System.Collections.Generic;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E14")]
public class AkBank : AkTriggerHandler
{
	[Token(Token = "0x401A4B9")]
	[FieldOffset(Offset = "0x18")]
	public Bank data;

	[Token(Token = "0x401A4BA")]
	[FieldOffset(Offset = "0x1C")]
	public bool decodeBank;

	[Token(Token = "0x401A4BB")]
	[FieldOffset(Offset = "0x1D")]
	public bool loadAsynchronous;

	[Token(Token = "0x401A4BC")]
	[FieldOffset(Offset = "0x1E")]
	public bool saveDecodedBank;

	[Token(Token = "0x401A4BD")]
	[FieldOffset(Offset = "0x20")]
	public List<int> unloadTriggerList;

	[Token(Token = "0x401A4BE")]
	[FieldOffset(Offset = "0x24")]
	private string bankNameInternal;

	[Token(Token = "0x401A4BF")]
	[FieldOffset(Offset = "0x28")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x17001B7B")]
	public string bankName
	{
		[Token(Token = "0x60193E9")]
		[Address(RVA = "0x35C6D94", Offset = "0x35C6D94", VA = "0x35C6D94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B7C")]
	public byte[] valueGuid
	{
		[Token(Token = "0x60193EA")]
		[Address(RVA = "0x35C6E44", Offset = "0x35C6E44", VA = "0x35C6E44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60193E3")]
	[Address(RVA = "0x35C693C", Offset = "0x35C693C", VA = "0x35C693C")]
	public AkBank()
	{
	}

	[Token(Token = "0x60193E4")]
	[Address(RVA = "0x35C6A48", Offset = "0x35C6A48", VA = "0x35C6A48", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60193E5")]
	[Address(RVA = "0x35C6B70", Offset = "0x35C6B70", VA = "0x35C6B70", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60193E6")]
	[Address(RVA = "0x35C6C20", Offset = "0x35C6C20", VA = "0x35C6C20", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x60193E7")]
	[Address(RVA = "0x35C6B48", Offset = "0x35C6B48", VA = "0x35C6B48")]
	public void UnloadBank(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x60193E8")]
	[Address(RVA = "0x35C6C94", Offset = "0x35C6C94", VA = "0x35C6C94", Slot = "7")]
	protected override void OnDestroy()
	{
	}
}
