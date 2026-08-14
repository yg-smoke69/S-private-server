using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20003F2")]
internal class FFAudioImpl : _Attribute
{
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x22FF9E4", Offset = "0x22FF9E4", VA = "0x22FF9E4")]
	public FFAudioImpl()
	{
	}

	[Token(Token = "0x6001288")]
	[Address(RVA = "0x22FF9EC", Offset = "0x22FF9EC", VA = "0x22FF9EC", Slot = "4")]
	public ResourceID GetTwoDAudioSourceResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001289")]
	[Address(RVA = "0x22FFA9C", Offset = "0x22FFA9C", VA = "0x22FFA9C", Slot = "5")]
	public float GetDistanceToListener(Vector3 sound_pos)
	{
		return default(float);
	}

	[Token(Token = "0x600128A")]
	[Address(RVA = "0x22FFCEC", Offset = "0x22FFCEC", VA = "0x22FFCEC", Slot = "6")]
	public int GetOneShotLimitInOneFrame()
	{
		return default(int);
	}

	[Token(Token = "0x600128B")]
	[Address(RVA = "0x22FFDC4", Offset = "0x22FFDC4", VA = "0x22FFDC4", Slot = "7")]
	public AKRESULT LoadAudioBankByResourceManager(string name, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x600128C")]
	[Address(RVA = "0x23000C4", Offset = "0x23000C4", VA = "0x23000C4", Slot = "8")]
	public AKRESULT LoadAndDecodeBankByResourceManager(string name, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x600128D")]
	[Address(RVA = "0x23003C4", Offset = "0x23003C4", VA = "0x23003C4", Slot = "10")]
	public AKRESULT UnLoadAudioBankByResourceManager(string name, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x2300560", Offset = "0x2300560", VA = "0x2300560", Slot = "11")]
	public void RemoveAudioBankRecord(string bank_name)
	{
	}

	[Token(Token = "0x600128F")]
	[Address(RVA = "0x23006E4", Offset = "0x23006E4", VA = "0x23006E4", Slot = "12")]
	public GameObject CreateWwiseGlobal(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x6001290")]
	[Address(RVA = "0x23008C8", Offset = "0x23008C8", VA = "0x23008C8", Slot = "13")]
	public GameObject AllocWwiseBaseObject(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x6001291")]
	[Address(RVA = "0x2300B2C", Offset = "0x2300B2C", VA = "0x2300B2C", Slot = "14")]
	public void CollectWwiseBaseObject(GameObject base_object)
	{
	}

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x2300C8C", Offset = "0x2300C8C", VA = "0x2300C8C", Slot = "9")]
	public AKRESULT LoadAudioBankAyncByResourceManager(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x2300F18", Offset = "0x2300F18", VA = "0x2300F18", Slot = "15")]
	public bool IsEnbaleAudioObjectOptimize()
	{
		return default(bool);
	}
}
