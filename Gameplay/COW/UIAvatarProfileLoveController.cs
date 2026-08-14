using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024C9")]
public class UIAvatarProfileLoveController : UIBaseController
{
	[Token(Token = "0x20024CA")]
	private sealed class _003CRequestOriLove_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E420")]
		[FieldOffset(Offset = "0x8")]
		internal bool flag;

		[Token(Token = "0x400E421")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarProfileLoveController _0024this;

		[Token(Token = "0x600D377")]
		[Address(RVA = "0x2F84BE0", Offset = "0x2F84BE0", VA = "0x2F84BE0")]
		public _003CRequestOriLove_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D378")]
		[Address(RVA = "0x2F84BE8", Offset = "0x2F84BE8", VA = "0x2F84BE8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20024CB")]
	private sealed class _003CRequestAwakenLove_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E422")]
		[FieldOffset(Offset = "0x8")]
		internal bool flag;

		[Token(Token = "0x400E423")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarProfileLoveController _0024this;

		[Token(Token = "0x600D379")]
		[Address(RVA = "0x2F84300", Offset = "0x2F84300", VA = "0x2F84300")]
		public _003CRequestAwakenLove_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D37A")]
		[Address(RVA = "0x2F84308", Offset = "0x2F84308", VA = "0x2F84308")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x600D37B")]
		[Address(RVA = "0x2F84718", Offset = "0x2F84718", VA = "0x2F84718")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x20024CC")]
	private sealed class _003CRequestLove_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E424")]
		[FieldOffset(Offset = "0x8")]
		internal bool flag;

		[Token(Token = "0x400E425")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarProfileLoveController _0024this;

		[Token(Token = "0x600D37C")]
		[Address(RVA = "0x2F84770", Offset = "0x2F84770", VA = "0x2F84770")]
		public _003CRequestLove_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600D37D")]
		[Address(RVA = "0x2F84778", Offset = "0x2F84778", VA = "0x2F84778")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x600D37E")]
		[Address(RVA = "0x2F84B88", Offset = "0x2F84B88", VA = "0x2F84B88")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400E416")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarProfileLoveView m_View;

	[Token(Token = "0x400E417")]
	[FieldOffset(Offset = "0x2C")]
	private AvatarProfile m_avatarprofile;

	[Token(Token = "0x400E418")]
	[FieldOffset(Offset = "0x30")]
	private uint m_avatarid;

	[Token(Token = "0x400E419")]
	[FieldOffset(Offset = "0x34")]
	private float m_curtime;

	[Token(Token = "0x400E41A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsAwaken;

	[Token(Token = "0x400E41B")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarProfile m_oriavatarprofile;

	[Token(Token = "0x400E41C")]
	[FieldOffset(Offset = "0x40")]
	private AvatarProfile m_awakenavatarprofile;

	[Token(Token = "0x400E41D")]
	[FieldOffset(Offset = "0x44")]
	private uint m_oriavatarid;

	[Token(Token = "0x400E41E")]
	[FieldOffset(Offset = "0x48")]
	private uint m_awakenavatarid;

	[Token(Token = "0x400E41F")]
	[FieldOffset(Offset = "0x4C")]
	protected uint m_DelayCallID;

	[Token(Token = "0x600D36D")]
	[Address(RVA = "0x2B75724", Offset = "0x2B75724", VA = "0x2B75724")]
	public UIAvatarProfileLoveController()
	{
	}

	[Token(Token = "0x600D36E")]
	[Address(RVA = "0x2B757A8", Offset = "0x2B757A8", VA = "0x2B757A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D36F")]
	[Address(RVA = "0x2B7584C", Offset = "0x2B7584C", VA = "0x2B7584C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D370")]
	[Address(RVA = "0x2B759E0", Offset = "0x2B759E0", VA = "0x2B759E0")]
	private void onLoveClick()
	{
	}

	[Token(Token = "0x600D371")]
	[Address(RVA = "0x2B77244", Offset = "0x2B77244", VA = "0x2B77244")]
	public void SetAwakenDataId(AvatarProfile profile1, AvatarProfile profile2)
	{
	}

	[Token(Token = "0x600D372")]
	[Address(RVA = "0x2B60580", Offset = "0x2B60580", VA = "0x2B60580")]
	public void SetDataId(AvatarProfile profile)
	{
	}

	[Token(Token = "0x600D373")]
	[Address(RVA = "0x2B76A24", Offset = "0x2B76A24", VA = "0x2B76A24")]
	private void RequestOriLove(uint avatarid, bool flag)
	{
	}

	[Token(Token = "0x600D374")]
	[Address(RVA = "0x2B76CDC", Offset = "0x2B76CDC", VA = "0x2B76CDC")]
	private void RequestAwakenLove(uint avatarid, bool flag)
	{
	}

	[Token(Token = "0x600D375")]
	[Address(RVA = "0x2B76F94", Offset = "0x2B76F94", VA = "0x2B76F94")]
	private void RequestLove(bool flag)
	{
	}

	[Token(Token = "0x600D376")]
	[Address(RVA = "0x2B773CC", Offset = "0x2B773CC", VA = "0x2B773CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
