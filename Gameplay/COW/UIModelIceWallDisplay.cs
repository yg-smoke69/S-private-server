using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030B0")]
public class UIModelIceWallDisplay : UIBaseModel
{
	[Token(Token = "0x4012850")]
	public const string HDICEDISPLAYGUIDE = "HDICEWALLDISPLAYGUIDE_";

	[Token(Token = "0x4012851")]
	public const string UILobbyIceDisplayGuideKey = "UILOBBYICEWALLDISPLAYGUIDEKEY_";

	[Token(Token = "0x4012852")]
	public const string UILobbyIceAutoRotateGuideKey = "UILOBBYICEWALLAutoRotateGUIDEKEY_";

	[Token(Token = "0x4012853")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CSelectedIceWallSkinID_003Ek__BackingField;

	[Token(Token = "0x4012854")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	[Token(Token = "0x4012855")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700152D")]
	public uint SelectedIceWallSkinID
	{
		[Token(Token = "0x6014613")]
		[Address(RVA = "0x12C4EA0", Offset = "0x12C4EA0", VA = "0x12C4EA0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014614")]
		[Address(RVA = "0x12C4EA8", Offset = "0x12C4EA8", VA = "0x12C4EA8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700152E")]
	public bool GetDataAfterLogin
	{
		[Token(Token = "0x6014615")]
		[Address(RVA = "0x12C4EB0", Offset = "0x12C4EB0", VA = "0x12C4EB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014616")]
		[Address(RVA = "0x12C4EB8", Offset = "0x12C4EB8", VA = "0x12C4EB8")]
		private set
		{
		}
	}

	[Token(Token = "0x6014612")]
	[Address(RVA = "0x12C4E1C", Offset = "0x12C4E1C", VA = "0x12C4E1C")]
	public UIModelIceWallDisplay()
	{
	}

	[Token(Token = "0x6014617")]
	[Address(RVA = "0x12C4EC0", Offset = "0x12C4EC0", VA = "0x12C4EC0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014618")]
	[Address(RVA = "0x12C4F18", Offset = "0x12C4F18", VA = "0x12C4F18", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014619")]
	[Address(RVA = "0x12C4F94", Offset = "0x12C4F94", VA = "0x12C4F94")]
	public void ProcessData(uint skinID)
	{
	}

	[Token(Token = "0x601461A")]
	[Address(RVA = "0x12C50B4", Offset = "0x12C50B4", VA = "0x12C50B4")]
	public void RequestSetIceSkinID(uint skinID, bool autorotate = false)
	{
	}

	[Token(Token = "0x601461B")]
	[Address(RVA = "0x12C5358", Offset = "0x12C5358", VA = "0x12C5358")]
	private static void _003CRequestSetIceSkinID_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601461C")]
	[Address(RVA = "0x12C535C", Offset = "0x12C535C", VA = "0x12C535C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
