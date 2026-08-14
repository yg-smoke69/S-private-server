using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002916")]
internal class UILobbyAdItemController : UIBaseController
{
	[Token(Token = "0x400FD06")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyAdItemView m_View;

	[Token(Token = "0x400FD07")]
	[FieldOffset(Offset = "0x2C")]
	public int AdIndex;

	[Token(Token = "0x400FD08")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_ImgObjects;

	[Token(Token = "0x60104CC")]
	[Address(RVA = "0x216589C", Offset = "0x216589C", VA = "0x216589C")]
	public UILobbyAdItemController()
	{
	}

	[Token(Token = "0x60104CD")]
	[Address(RVA = "0x2165920", Offset = "0x2165920", VA = "0x2165920")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104CE")]
	[Address(RVA = "0x21659C4", Offset = "0x21659C4", VA = "0x21659C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104CF")]
	[Address(RVA = "0x2165B68", Offset = "0x2165B68", VA = "0x2165B68")]
	public void SetNetworkTextureSize(int width, int height)
	{
	}

	[Token(Token = "0x60104D0")]
	[Address(RVA = "0x2165CE8", Offset = "0x2165CE8", VA = "0x2165CE8")]
	public void RefreshUIData(UIModelLobbyAds.AdInfo info)
	{
	}

	[Token(Token = "0x60104D1")]
	[Address(RVA = "0x21661F0", Offset = "0x21661F0", VA = "0x21661F0")]
	private void _003CRefreshUIData_003Em__0()
	{
	}

	[Token(Token = "0x60104D2")]
	[Address(RVA = "0x2166254", Offset = "0x2166254", VA = "0x2166254")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
