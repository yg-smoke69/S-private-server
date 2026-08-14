using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022CB")]
internal class UIHudReaperDashController : UIHudButtonBaseController
{
	[Token(Token = "0x20022CC")]
	private sealed class _003CCoolDown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D972")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudReaperDashController _0024this;

		[Token(Token = "0x400D973")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D974")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D975")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700109E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BFB4")]
			[Address(RVA = "0x1FD9C44", Offset = "0x1FD9C44", VA = "0x1FD9C44", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700109F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BFB5")]
			[Address(RVA = "0x1FD9C4C", Offset = "0x1FD9C4C", VA = "0x1FD9C4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BFB2")]
		[Address(RVA = "0x1FD998C", Offset = "0x1FD998C", VA = "0x1FD998C")]
		public _003CCoolDown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BFB3")]
		[Address(RVA = "0x1FD9AAC", Offset = "0x1FD9AAC", VA = "0x1FD9AAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BFB6")]
		[Address(RVA = "0x1FD9C54", Offset = "0x1FD9C54", VA = "0x1FD9C54", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BFB7")]
		[Address(RVA = "0x1FD9C68", Offset = "0x1FD9C68", VA = "0x1FD9C68", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D970")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudReaperDashBtnView m_View;

	[Token(Token = "0x400D971")]
	[FieldOffset(Offset = "0x30")]
	private float m_CoolDownLeft;

	[Token(Token = "0x600BFA8")]
	[Address(RVA = "0x1FD90EC", Offset = "0x1FD90EC", VA = "0x1FD90EC")]
	public UIHudReaperDashController()
	{
	}

	[Token(Token = "0x600BFA9")]
	[Address(RVA = "0x1FD90F4", Offset = "0x1FD90F4", VA = "0x1FD90F4", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600BFAA")]
	[Address(RVA = "0x1FD9198", Offset = "0x1FD9198", VA = "0x1FD9198")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFAB")]
	[Address(RVA = "0x1FD923C", Offset = "0x1FD923C", VA = "0x1FD923C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFAC")]
	[Address(RVA = "0x1FD9500", Offset = "0x1FD9500", VA = "0x1FD9500", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600BFAD")]
	[Address(RVA = "0x1FD9608", Offset = "0x1FD9608", VA = "0x1FD9608")]
	private void OnCastReaperDash(object[] data)
	{
	}

	[Token(Token = "0x600BFAE")]
	[Address(RVA = "0x1FD98C0", Offset = "0x1FD98C0", VA = "0x1FD98C0")]
	private IEnumerator CoolDown()
	{
		return null;
	}

	[Token(Token = "0x600BFAF")]
	[Address(RVA = "0x1FD9994", Offset = "0x1FD9994", VA = "0x1FD9994")]
	private void OnCoolFinished()
	{
	}

	[Token(Token = "0x600BFB0")]
	[Address(RVA = "0x1FD9A9C", Offset = "0x1FD9A9C", VA = "0x1FD9A9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BFB1")]
	[Address(RVA = "0x1FD9AA4", Offset = "0x1FD9AA4", VA = "0x1FD9AA4")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
