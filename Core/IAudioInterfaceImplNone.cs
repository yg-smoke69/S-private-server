using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E61")]
public class IAudioInterfaceImplNone : _Attribute
{
	[Token(Token = "0x60195EC")]
	[Address(RVA = "0x35183FC", Offset = "0x35183FC", VA = "0x35183FC")]
	public IAudioInterfaceImplNone()
	{
	}

	[Token(Token = "0x60195ED")]
	[Address(RVA = "0x3518404", Offset = "0x3518404", VA = "0x3518404", Slot = "4")]
	public ResourceID GetTwoDAudioSourceResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60195EE")]
	[Address(RVA = "0x3518490", Offset = "0x3518490", VA = "0x3518490", Slot = "5")]
	public float GetDistanceToListener(Vector3 sound_pos)
	{
		return default(float);
	}

	[Token(Token = "0x60195EF")]
	[Address(RVA = "0x351849C", Offset = "0x351849C", VA = "0x351849C", Slot = "6")]
	public int GetOneShotLimitInOneFrame()
	{
		return default(int);
	}

	[Token(Token = "0x60195F0")]
	[Address(RVA = "0x35184A4", Offset = "0x35184A4", VA = "0x35184A4", Slot = "7")]
	public AKRESULT LoadAudioBankByResourceManager(string name, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195F1")]
	[Address(RVA = "0x35184B4", Offset = "0x35184B4", VA = "0x35184B4", Slot = "10")]
	public AKRESULT UnLoadAudioBankByResourceManager(string in_pszString, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195F2")]
	[Address(RVA = "0x35184BC", Offset = "0x35184BC", VA = "0x35184BC", Slot = "12")]
	public GameObject CreateWwiseGlobal(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x60195F3")]
	[Address(RVA = "0x35184C4", Offset = "0x35184C4", VA = "0x35184C4", Slot = "13")]
	public GameObject AllocWwiseBaseObject(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x60195F4")]
	[Address(RVA = "0x35184CC", Offset = "0x35184CC", VA = "0x35184CC", Slot = "14")]
	public void CollectWwiseBaseObject(GameObject base_object)
	{
	}

	[Token(Token = "0x60195F5")]
	[Address(RVA = "0x35184D0", Offset = "0x35184D0", VA = "0x35184D0", Slot = "8")]
	public AKRESULT LoadAndDecodeBankByResourceManager(string name, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195F6")]
	[Address(RVA = "0x35184E0", Offset = "0x35184E0", VA = "0x35184E0", Slot = "11")]
	public void RemoveAudioBankRecord(string bank_name)
	{
	}

	[Token(Token = "0x60195F7")]
	[Address(RVA = "0x35184E4", Offset = "0x35184E4", VA = "0x35184E4", Slot = "9")]
	public AKRESULT LoadAudioBankAyncByResourceManager(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195F8")]
	[Address(RVA = "0x3518540", Offset = "0x3518540", VA = "0x3518540", Slot = "15")]
	public bool IsEnbaleAudioObjectOptimize()
	{
		return default(bool);
	}
}
