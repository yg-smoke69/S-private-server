using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D8B")]
public class UINetworkTextureExt : UINetworkTexture
{
	[Token(Token = "0x4011773")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LoadingMask;

	[Token(Token = "0x4011774")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Loading;

	[Token(Token = "0x4011775")]
	[FieldOffset(Offset = "0x38")]
	public Action<Texture> Callback;

	[Token(Token = "0x60130EF")]
	[Address(RVA = "0x2797DE8", Offset = "0x2797DE8", VA = "0x2797DE8")]
	public UINetworkTextureExt()
	{
	}

	[Token(Token = "0x60130F0")]
	[Address(RVA = "0x2797DF0", Offset = "0x2797DF0", VA = "0x2797DF0")]
	public void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool showLoading = false, bool adjustLoadingDepth = false)
	{
	}

	[Token(Token = "0x60130F1")]
	[Address(RVA = "0x2798218", Offset = "0x2798218", VA = "0x2798218", Slot = "5")]
	public override void OnDowloadFinished(Texture texture)
	{
	}

	[Token(Token = "0x60130F2")]
	[Address(RVA = "0x2798468", Offset = "0x2798468", VA = "0x2798468")]
	public void _003C_003EiFixBaseProxy_OnDowloadFinished(Texture P0)
	{
	}
}
