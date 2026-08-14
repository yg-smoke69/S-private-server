using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022BA")]
public class UIHUDPVEMissionCenterTipController : UIBaseController
{
	[Token(Token = "0x20022BB")]
	public delegate void OnAnimFinish(string content);

	[Token(Token = "0x20022BC")]
	private sealed class _003CStartShow_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D930")]
		[FieldOffset(Offset = "0x8")]
		internal string content;

		[Token(Token = "0x400D931")]
		[FieldOffset(Offset = "0xC")]
		internal UIHUDPVEMissionCenterTipController _0024this;

		[Token(Token = "0x400D932")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400D933")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400D934")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001099")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BF18")]
			[Address(RVA = "0x16840B4", Offset = "0x16840B4", VA = "0x16840B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700109A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BF19")]
			[Address(RVA = "0x16840BC", Offset = "0x16840BC", VA = "0x16840BC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BF16")]
		[Address(RVA = "0x1683AD0", Offset = "0x1683AD0", VA = "0x1683AD0")]
		public _003CStartShow_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BF17")]
		[Address(RVA = "0x1683AE0", Offset = "0x1683AE0", VA = "0x1683AE0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BF1A")]
		[Address(RVA = "0x16840C4", Offset = "0x16840C4", VA = "0x16840C4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BF1B")]
		[Address(RVA = "0x16840D8", Offset = "0x16840D8", VA = "0x16840D8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D92D")]
	[FieldOffset(Offset = "0x28")]
	public OnAnimFinish action_OnShowOver;

	[Token(Token = "0x400D92E")]
	[FieldOffset(Offset = "0x2C")]
	private HUDPVEMissionCenterTipView m_View;

	[Token(Token = "0x400D92F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsShowAnimFinished;

	[Token(Token = "0x17001098")]
	public float ContentWidth
	{
		[Token(Token = "0x600BF0D")]
		[Address(RVA = "0x1683738", Offset = "0x1683738", VA = "0x1683738")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600BF0B")]
	[Address(RVA = "0x168360C", Offset = "0x168360C", VA = "0x168360C")]
	public UIHUDPVEMissionCenterTipController()
	{
	}

	[Token(Token = "0x600BF0C")]
	[Address(RVA = "0x1683690", Offset = "0x1683690", VA = "0x1683690")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF0E")]
	[Address(RVA = "0x16837D0", Offset = "0x16837D0", VA = "0x16837D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF0F")]
	[Address(RVA = "0x168388C", Offset = "0x168388C", VA = "0x168388C")]
	public void OnMissionCome(string content)
	{
	}

	[Token(Token = "0x600BF10")]
	[Address(RVA = "0x16839E4", Offset = "0x16839E4", VA = "0x16839E4")]
	private IEnumerator StartShow(string content)
	{
		return null;
	}

	[Token(Token = "0x600BF11")]
	[Address(RVA = "0x1683AD8", Offset = "0x1683AD8", VA = "0x1683AD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
