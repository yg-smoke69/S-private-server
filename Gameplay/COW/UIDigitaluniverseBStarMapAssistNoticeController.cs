using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EF8")]
internal class UIDigitaluniverseBStarMapAssistNoticeController : UIBaseController
{
	[Token(Token = "0x2001EF9")]
	private sealed class _003CPlayAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C2F2")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBStarMapAssistNoticeController _0024this;

		[Token(Token = "0x400C2F3")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C2F4")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C2F5")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F6E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600976A")]
			[Address(RVA = "0x2F10014", Offset = "0x2F10014", VA = "0x2F10014", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F6F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600976B")]
			[Address(RVA = "0x2F1001C", Offset = "0x2F1001C", VA = "0x2F1001C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009768")]
		[Address(RVA = "0x2F0FF0C", Offset = "0x2F0FF0C", VA = "0x2F0FF0C")]
		public _003CPlayAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009769")]
		[Address(RVA = "0x2F0FF1C", Offset = "0x2F0FF1C", VA = "0x2F0FF1C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600976C")]
		[Address(RVA = "0x2F10024", Offset = "0x2F10024", VA = "0x2F10024", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600976D")]
		[Address(RVA = "0x2F10038", Offset = "0x2F10038", VA = "0x2F10038", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C2F1")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBStarMapAssistNoticeView m_View;

	[Token(Token = "0x6009762")]
	[Address(RVA = "0x2F0FA0C", Offset = "0x2F0FA0C", VA = "0x2F0FA0C")]
	public UIDigitaluniverseBStarMapAssistNoticeController()
	{
	}

	[Token(Token = "0x6009763")]
	[Address(RVA = "0x2F0FA90", Offset = "0x2F0FA90", VA = "0x2F0FA90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009764")]
	[Address(RVA = "0x2F0FB38", Offset = "0x2F0FB38", VA = "0x2F0FB38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009765")]
	[Address(RVA = "0x2F0FBF4", Offset = "0x2F0FBF4", VA = "0x2F0FBF4")]
	public void SetViewData(CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo info)
	{
	}

	[Token(Token = "0x6009766")]
	[Address(RVA = "0x2F0FE40", Offset = "0x2F0FE40", VA = "0x2F0FE40")]
	private IEnumerator PlayAnimation()
	{
		return null;
	}

	[Token(Token = "0x6009767")]
	[Address(RVA = "0x2F0FF14", Offset = "0x2F0FF14", VA = "0x2F0FF14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
