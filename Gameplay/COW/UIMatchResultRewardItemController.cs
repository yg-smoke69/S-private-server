using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029A5")]
public class UIMatchResultRewardItemController : UIBaseController
{
	[Token(Token = "0x20029A6")]
	private sealed class _003CPlayTextAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010046")]
		[FieldOffset(Offset = "0x8")]
		internal float _003ClerpValue_003E__0;

		[Token(Token = "0x4010047")]
		[FieldOffset(Offset = "0xC")]
		internal float duration;

		[Token(Token = "0x4010048")]
		[FieldOffset(Offset = "0x10")]
		internal uint oldnum;

		[Token(Token = "0x4010049")]
		[FieldOffset(Offset = "0x14")]
		internal uint nownum;

		[Token(Token = "0x401004A")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CcurNum_003E__1;

		[Token(Token = "0x401004B")]
		[FieldOffset(Offset = "0x1C")]
		internal string ratioColor;

		[Token(Token = "0x401004C")]
		[FieldOffset(Offset = "0x20")]
		internal uint maxnum;

		[Token(Token = "0x401004D")]
		[FieldOffset(Offset = "0x24")]
		internal UILabel Label;

		[Token(Token = "0x401004E")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x401004F")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x4010050")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17001264")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010BC9")]
			[Address(RVA = "0x281D914", Offset = "0x281D914", VA = "0x281D914", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001265")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010BCA")]
			[Address(RVA = "0x281D91C", Offset = "0x281D91C", VA = "0x281D91C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010BC7")]
		[Address(RVA = "0x281C5C8", Offset = "0x281C5C8", VA = "0x281C5C8")]
		public _003CPlayTextAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010BC8")]
		[Address(RVA = "0x281D650", Offset = "0x281D650", VA = "0x281D650", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010BCB")]
		[Address(RVA = "0x281D924", Offset = "0x281D924", VA = "0x281D924", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010BCC")]
		[Address(RVA = "0x281D938", Offset = "0x281D938", VA = "0x281D938", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20029A7")]
	private sealed class _003CPlayTokenTextAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010051")]
		[FieldOffset(Offset = "0x8")]
		internal float _003ClerpValue_003E__0;

		[Token(Token = "0x4010052")]
		[FieldOffset(Offset = "0xC")]
		internal float duration;

		[Token(Token = "0x4010053")]
		[FieldOffset(Offset = "0x10")]
		internal uint oldnum;

		[Token(Token = "0x4010054")]
		[FieldOffset(Offset = "0x14")]
		internal uint nownum;

		[Token(Token = "0x4010055")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CcurNum_003E__1;

		[Token(Token = "0x4010056")]
		[FieldOffset(Offset = "0x1C")]
		internal UILabel Label;

		[Token(Token = "0x4010057")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4010058")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4010059")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001266")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010BCF")]
			[Address(RVA = "0x281DBA8", Offset = "0x281DBA8", VA = "0x281DBA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001267")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010BD0")]
			[Address(RVA = "0x281DBB0", Offset = "0x281DBB0", VA = "0x281DBB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010BCD")]
		[Address(RVA = "0x281C5D0", Offset = "0x281C5D0", VA = "0x281C5D0")]
		public _003CPlayTokenTextAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6010BCE")]
		[Address(RVA = "0x281D9C0", Offset = "0x281D9C0", VA = "0x281D9C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010BD1")]
		[Address(RVA = "0x281DBB8", Offset = "0x281DBB8", VA = "0x281DBB8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010BD2")]
		[Address(RVA = "0x281DBCC", Offset = "0x281DBCC", VA = "0x281DBCC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010039")]
	[FieldOffset(Offset = "0x28")]
	private MatchResultRewardInfo m_Data;

	[Token(Token = "0x401003A")]
	[FieldOffset(Offset = "0x2C")]
	private UIMatchResultRewardItemView m_View;

	[Token(Token = "0x401003B")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallShowBtn;

	[Token(Token = "0x401003C")]
	[FieldOffset(Offset = "0x34")]
	private uint m_DelayCallShowRestrictedLabel;

	[Token(Token = "0x401003D")]
	private const float DURATION = 1f;

	[Token(Token = "0x401003E")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine m_TokenTodayCoroutine;

	[Token(Token = "0x401003F")]
	[FieldOffset(Offset = "0x3C")]
	private Coroutine m_TokenOwnedCoroutine;

	[Token(Token = "0x4010040")]
	[FieldOffset(Offset = "0x40")]
	private List<Coroutine> m_DebrisTextCoroutineList;

	[Token(Token = "0x4010041")]
	private const string RATIO_OWNED_STR = "[EFEFEF]{0}[-][BBBBBB]/{1}[-]";

	[Token(Token = "0x4010042")]
	private const string RATIO_DAILY_STR = "{0}/{1}";

	[Token(Token = "0x4010043")]
	private const string DEFAULT_STR = "0";

	[Token(Token = "0x4010044")]
	[FieldOffset(Offset = "0x0")]
	private static Callback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010045")]
	[FieldOffset(Offset = "0x4")]
	private static Callback _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6010BAC")]
	[Address(RVA = "0x28198E4", Offset = "0x28198E4", VA = "0x28198E4")]
	public UIMatchResultRewardItemController()
	{
	}

	[Token(Token = "0x6010BAD")]
	[Address(RVA = "0x281999C", Offset = "0x281999C", VA = "0x281999C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010BAE")]
	[Address(RVA = "0x2819A40", Offset = "0x2819A40", VA = "0x2819A40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010BAF")]
	[Address(RVA = "0x2819B9C", Offset = "0x2819B9C", VA = "0x2819B9C", Slot = "31")]
	protected virtual UIStandardItemMAXBController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010BB0")]
	[Address(RVA = "0x2819C94", Offset = "0x2819C94", VA = "0x2819C94")]
	public void SetViewData(object data)
	{
	}

	[Token(Token = "0x6010BB1")]
	[Address(RVA = "0x281B6C0", Offset = "0x281B6C0", VA = "0x281B6C0")]
	private void GotoOthers()
	{
	}

	[Token(Token = "0x6010BB2")]
	[Address(RVA = "0x281A7EC", Offset = "0x281A7EC", VA = "0x281A7EC")]
	private void SetLinkOwnedInfo()
	{
	}

	[Token(Token = "0x6010BB3")]
	[Address(RVA = "0x281B07C", Offset = "0x281B07C", VA = "0x281B07C")]
	private void SetDebrisOwnedInfo()
	{
	}

	[Token(Token = "0x6010BB4")]
	[Address(RVA = "0x281AC40", Offset = "0x281AC40", VA = "0x281AC40")]
	private void SetGainedTodayInfo()
	{
	}

	[Token(Token = "0x6010BB5")]
	[Address(RVA = "0x281C1C8", Offset = "0x281C1C8", VA = "0x281C1C8")]
	private void StartPlayAnimationText(uint oldnum, uint nownum, UILabel Label, uint maxnum, string ratioColor)
	{
	}

	[Token(Token = "0x6010BB6")]
	[Address(RVA = "0x281C444", Offset = "0x281C444", VA = "0x281C444")]
	private IEnumerator PlayTextAnimation(uint oldnum, uint nownum, float duration, UILabel Label, uint maxnum, string ratioColor)
	{
		return null;
	}

	[Token(Token = "0x6010BB7")]
	[Address(RVA = "0x281B580", Offset = "0x281B580", VA = "0x281B580")]
	private IEnumerator PlayTokenTextAnimation(uint oldnum, uint nownum, float duration, UILabel Label)
	{
		return null;
	}

	[Token(Token = "0x6010BB8")]
	[Address(RVA = "0x281C07C", Offset = "0x281C07C", VA = "0x281C07C")]
	private void DelayShowUpgradeBtn()
	{
	}

	[Token(Token = "0x6010BB9")]
	[Address(RVA = "0x281C2F8", Offset = "0x281C2F8", VA = "0x281C2F8")]
	private void DelayShowRestrictedLabel()
	{
	}

	[Token(Token = "0x6010BBA")]
	[Address(RVA = "0x281BFC4", Offset = "0x281BFC4", VA = "0x281BFC4")]
	private void PalayProgressAni(float toData)
	{
	}

	[Token(Token = "0x6010BBB")]
	[Address(RVA = "0x281C5D8", Offset = "0x281C5D8", VA = "0x281C5D8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010BBC")]
	[Address(RVA = "0x281C63C", Offset = "0x281C63C", VA = "0x281C63C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010BBD")]
	[Address(RVA = "0x281C6A0", Offset = "0x281C6A0", VA = "0x281C6A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010BBE")]
	[Address(RVA = "0x281C98C", Offset = "0x281C98C", VA = "0x281C98C")]
	public void StopAllAni()
	{
	}

	[Token(Token = "0x6010BBF")]
	[Address(RVA = "0x281D090", Offset = "0x281D090", VA = "0x281D090")]
	private static void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x6010BC0")]
	[Address(RVA = "0x281D2A0", Offset = "0x281D2A0", VA = "0x281D2A0")]
	private static void _003CSetViewData_003Em__1()
	{
	}

	[Token(Token = "0x6010BC1")]
	[Address(RVA = "0x281D4B0", Offset = "0x281D4B0", VA = "0x281D4B0")]
	private void _003CDelayShowUpgradeBtn_003Em__2()
	{
	}

	[Token(Token = "0x6010BC2")]
	[Address(RVA = "0x281D560", Offset = "0x281D560", VA = "0x281D560")]
	private void _003CDelayShowRestrictedLabel_003Em__3()
	{
	}

	[Token(Token = "0x6010BC3")]
	[Address(RVA = "0x281D630", Offset = "0x281D630", VA = "0x281D630")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010BC4")]
	[Address(RVA = "0x281D638", Offset = "0x281D638", VA = "0x281D638")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010BC5")]
	[Address(RVA = "0x281D640", Offset = "0x281D640", VA = "0x281D640")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010BC6")]
	[Address(RVA = "0x281D648", Offset = "0x281D648", VA = "0x281D648")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
