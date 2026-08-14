using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA8")]
public class AvatarProfileDataManager : SingletonModule<AvatarProfileDataManager>, _Attribute
{
	[Token(Token = "0x4011875")]
	[FieldOffset(Offset = "0xC")]
	private UIModelAvatarProfile m_ModelAvatarProfile;

	[Token(Token = "0x4011876")]
	[FieldOffset(Offset = "0x10")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4011877")]
	[FieldOffset(Offset = "0x14")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x4011878")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsBackpackReady;

	[Token(Token = "0x4011879")]
	[FieldOffset(Offset = "0x19")]
	private bool m_IsAvatarInfoReady;

	[Token(Token = "0x60131D5")]
	[Address(RVA = "0x23518CC", Offset = "0x23518CC", VA = "0x23518CC")]
	public AvatarProfileDataManager()
	{
	}

	[Token(Token = "0x60131D6")]
	[Address(RVA = "0x235195C", Offset = "0x235195C", VA = "0x235195C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60131D7")]
	[Address(RVA = "0x2351E08", Offset = "0x2351E08", VA = "0x2351E08", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60131D8")]
	[Address(RVA = "0x2351E64", Offset = "0x2351E64", VA = "0x2351E64")]
	public void ClearData()
	{
	}

	[Token(Token = "0x60131D9")]
	[Address(RVA = "0x2351EC0", Offset = "0x2351EC0", VA = "0x2351EC0", Slot = "10")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60131DA")]
	[Address(RVA = "0x23523E8", Offset = "0x23523E8", VA = "0x23523E8", Slot = "11")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}
}
