using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D89")]
internal class UIGlobalCOWImpl : _Attribute
{
	[Token(Token = "0x2002D8A")]
	private sealed class _003CPlayButtonClickSound_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011772")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID delay_sound_resID;

		[Token(Token = "0x60130ED")]
		[Address(RVA = "0x1CF6540", Offset = "0x1CF6540", VA = "0x1CF6540")]
		public _003CPlayButtonClickSound_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60130EE")]
		[Address(RVA = "0x1CF67A8", Offset = "0x1CF67A8", VA = "0x1CF67A8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4011771")]
	private const string LOADING_SPRITENAME = "";

	[Token(Token = "0x60130E6")]
	[Address(RVA = "0x1CF5CD8", Offset = "0x1CF5CD8", VA = "0x1CF5CD8")]
	public UIGlobalCOWImpl()
	{
	}

	[Token(Token = "0x60130E7")]
	[Address(RVA = "0x1CF5CE0", Offset = "0x1CF5CE0", VA = "0x1CF5CE0", Slot = "8")]
	public void CancelGameDelayCall(uint id)
	{
	}

	[Token(Token = "0x60130E8")]
	[Address(RVA = "0x1CF5DE0", Offset = "0x1CF5DE0", VA = "0x1CF5DE0", Slot = "5")]
	public bool CheckIsInSpectatorSoundRange(Vector3 pos, uint resouceId)
	{
		return default(bool);
	}

	[Token(Token = "0x60130E9")]
	[Address(RVA = "0x1CF5E64", Offset = "0x1CF5E64", VA = "0x1CF5E64", Slot = "7")]
	public uint GameDelayCall(float delayTime, Action action, bool isRepeated = false)
	{
		return default(uint);
	}

	[Token(Token = "0x60130EA")]
	[Address(RVA = "0x1CF5F8C", Offset = "0x1CF5F8C", VA = "0x1CF5F8C", Slot = "4")]
	public void PlayButtonClickSound(string soundID, string delaySoundId, float delayTime)
	{
	}

	[Token(Token = "0x60130EB")]
	[Address(RVA = "0x1CF6548", Offset = "0x1CF6548", VA = "0x1CF6548", Slot = "9")]
	public void RegisterKeyAction(string name, UIButton btn)
	{
	}

	[Token(Token = "0x60130EC")]
	[Address(RVA = "0x1CF65B8", Offset = "0x1CF65B8", VA = "0x1CF65B8", Slot = "6")]
	public void SetNetworkTextureLoadingSprite(UISprite loadingSprite)
	{
	}
}
