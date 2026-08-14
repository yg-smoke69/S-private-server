using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002922")]
internal class UILobbyDotController : UIBaseController
{
	[Token(Token = "0x400FD55")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyDotView m_View;

	[Token(Token = "0x400FD56")]
	[FieldOffset(Offset = "0x2C")]
	public int DotIndex;

	[Token(Token = "0x6010524")]
	[Address(RVA = "0xD9D0FC", Offset = "0xD9D0FC", VA = "0xD9D0FC")]
	public UILobbyDotController()
	{
	}

	[Token(Token = "0x6010525")]
	[Address(RVA = "0xD9D180", Offset = "0xD9D180", VA = "0xD9D180")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010526")]
	[Address(RVA = "0xD9D224", Offset = "0xD9D224", VA = "0xD9D224", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010527")]
	[Address(RVA = "0xD9D350", Offset = "0xD9D350", VA = "0xD9D350")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x6010528")]
	[Address(RVA = "0xD9D420", Offset = "0xD9D420", VA = "0xD9D420")]
	public void SetDotEnableSize(int width, int height, Type type = 0)
	{
	}

	[Token(Token = "0x6010529")]
	[Address(RVA = "0xD9D5E0", Offset = "0xD9D5E0", VA = "0xD9D5E0")]
	public void SetDotDisableSize(int width, int height, Type type = 0)
	{
	}

	[Token(Token = "0x601052A")]
	[Address(RVA = "0xD9D758", Offset = "0xD9D758", VA = "0xD9D758")]
	public void SetDisableDotSprite(string spriteName)
	{
	}

	[Token(Token = "0x601052B")]
	[Address(RVA = "0xD9D8C0", Offset = "0xD9D8C0", VA = "0xD9D8C0")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x601052C")]
	[Address(RVA = "0xD9DA24", Offset = "0xD9DA24", VA = "0xD9DA24")]
	public void SetHeight(int height)
	{
	}

	[Token(Token = "0x601052D")]
	[Address(RVA = "0xD9DB88", Offset = "0xD9DB88", VA = "0xD9DB88")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x601052E")]
	[Address(RVA = "0xD9DCEC", Offset = "0xD9DCEC", VA = "0xD9DCEC")]
	public void SetDotSprite(string enable, string disable)
	{
	}

	[Token(Token = "0x601052F")]
	[Address(RVA = "0xD9DE88", Offset = "0xD9DE88", VA = "0xD9DE88")]
	public void SetDotSprite(UISprite enable, UISprite disable, Vector3 scale)
	{
	}

	[Token(Token = "0x6010530")]
	[Address(RVA = "0xD9E1F4", Offset = "0xD9E1F4", VA = "0xD9E1F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
