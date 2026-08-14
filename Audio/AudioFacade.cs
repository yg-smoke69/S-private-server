using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E62")]
public static class AudioFacade
{
	[Token(Token = "0x401A60C")]
	[FieldOffset(Offset = "0x0")]
	private static IAudioInterface m_Impl;

	[Token(Token = "0x60195F9")]
	[Address(RVA = "0x2ECDFE4", Offset = "0x2ECDFE4", VA = "0x2ECDFE4")]
	public static void SetImpl(IAudioInterface impl)
	{
	}

	[Token(Token = "0x60195FA")]
	[Address(RVA = "0x2ECE09C", Offset = "0x2ECE09C", VA = "0x2ECE09C")]
	public static ResourceID GetTwoDAudioSourceResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60195FB")]
	[Address(RVA = "0x2ECE240", Offset = "0x2ECE240", VA = "0x2ECE240")]
	public static float GetDistanceToListener(Vector3 sound_pos)
	{
		return default(float);
	}

	[Token(Token = "0x60195FC")]
	[Address(RVA = "0x2ECE3D4", Offset = "0x2ECE3D4", VA = "0x2ECE3D4")]
	public static int GetOneShotLimitInOneFrame()
	{
		return default(int);
	}

	[Token(Token = "0x60195FD")]
	[Address(RVA = "0x2ECE538", Offset = "0x2ECE538", VA = "0x2ECE538")]
	public static AKRESULT LoadAudioBankByResourceManager(string name, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195FE")]
	[Address(RVA = "0x2ECE6D0", Offset = "0x2ECE6D0", VA = "0x2ECE6D0")]
	public static AKRESULT UnLoadAudioBankByResourceManager(string in_pszString, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195FF")]
	[Address(RVA = "0x2ECE850", Offset = "0x2ECE850", VA = "0x2ECE850")]
	public static AKRESULT LoadAndDecodeBankByResourceManager(string name, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6019600")]
	[Address(RVA = "0x2ECE9E8", Offset = "0x2ECE9E8", VA = "0x2ECE9E8")]
	public static GameObject CreateWwiseGlobal(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x6019601")]
	[Address(RVA = "0x2ECEB54", Offset = "0x2ECEB54", VA = "0x2ECEB54")]
	public static GameObject AllocWwiseBaseObject(Transform _parent)
	{
		return null;
	}

	[Token(Token = "0x6019602")]
	[Address(RVA = "0x2ECECC0", Offset = "0x2ECECC0", VA = "0x2ECECC0")]
	public static void CollectWwiseBaseObject(GameObject base_object)
	{
	}

	[Token(Token = "0x6019603")]
	[Address(RVA = "0x2ECEE28", Offset = "0x2ECEE28", VA = "0x2ECEE28")]
	public static void RemoveAudioBankRecord(string bank_name)
	{
	}

	[Token(Token = "0x6019604")]
	[Address(RVA = "0x2ECEF90", Offset = "0x2ECEF90", VA = "0x2ECEF90")]
	public static bool IsEnbaleAudioObjectOptimize()
	{
		return default(bool);
	}
}
