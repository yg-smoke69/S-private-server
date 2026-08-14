using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E60")]
public interface IAudioInterface
{
	[Token(Token = "0x60195E0")]
	ResourceID GetTwoDAudioSourceResID();

	[Token(Token = "0x60195E1")]
	float GetDistanceToListener(Vector3 sound_pos);

	[Token(Token = "0x60195E2")]
	int GetOneShotLimitInOneFrame();

	[Token(Token = "0x60195E3")]
	AKRESULT LoadAudioBankByResourceManager(string name, int in_memPoolId, out uint out_bankID);

	[Token(Token = "0x60195E4")]
	AKRESULT LoadAndDecodeBankByResourceManager(string name, bool in_bSaveDecodedBank, out uint out_bankID);

	[Token(Token = "0x60195E5")]
	AKRESULT LoadAudioBankAyncByResourceManager(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID);

	[Token(Token = "0x60195E6")]
	AKRESULT UnLoadAudioBankByResourceManager(string in_pszString, IntPtr in_pInMemoryBankPtr);

	[Token(Token = "0x60195E7")]
	void RemoveAudioBankRecord(string bank_name);

	[Token(Token = "0x60195E8")]
	GameObject CreateWwiseGlobal(Transform _parent);

	[Token(Token = "0x60195E9")]
	GameObject AllocWwiseBaseObject(Transform _parent);

	[Token(Token = "0x60195EA")]
	void CollectWwiseBaseObject(GameObject base_object);

	[Token(Token = "0x60195EB")]
	bool IsEnbaleAudioObjectOptimize();
}
