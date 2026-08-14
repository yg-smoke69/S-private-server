using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027AD")]
internal class UIHudMatchEndShowTimeControllerBase : UIBaseController
{
	[Token(Token = "0x20027AE")]
	private sealed class _003CProcessUpdateCloseTime_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F4EC")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudMatchEndShowTimeControllerBase _0024this;

		[Token(Token = "0x400F4ED")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F4EE")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F4EF")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F4E0")]
			[Address(RVA = "0xFFE33C", Offset = "0xFFE33C", VA = "0xFFE33C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F4E1")]
			[Address(RVA = "0xFFE344", Offset = "0xFFE344", VA = "0xFFE344", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F4DE")]
		[Address(RVA = "0xFFDE44", Offset = "0xFFDE44", VA = "0xFFDE44")]
		public _003CProcessUpdateCloseTime_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F4DF")]
		[Address(RVA = "0xFFDFFC", Offset = "0xFFDFFC", VA = "0xFFDFFC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F4E2")]
		[Address(RVA = "0xFFE34C", Offset = "0xFFE34C", VA = "0xFFE34C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F4E3")]
		[Address(RVA = "0xFFE360", Offset = "0xFFE360", VA = "0xFFE360", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F4E8")]
	[FieldOffset(Offset = "0x28")]
	private Action m_callBack;

	[Token(Token = "0x400F4E9")]
	[FieldOffset(Offset = "0x2C")]
	private float m_timeShowing;

	[Token(Token = "0x400F4EA")]
	private const string showFormat = "({0}s)";

	[Token(Token = "0x400F4EB")]
	[FieldOffset(Offset = "0x30")]
	protected UILabel m_TimeLabel;

	[Token(Token = "0x170011D5")]
	private float DurationForEatingChicken
	{
		[Token(Token = "0x600F4D8")]
		[Address(RVA = "0xFFDA30", Offset = "0xFFDA30", VA = "0xFFDA30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600F4D7")]
	[Address(RVA = "0xFFACA8", Offset = "0xFFACA8", VA = "0xFFACA8")]
	public UIHudMatchEndShowTimeControllerBase()
	{
	}

	[Token(Token = "0x600F4D9")]
	[Address(RVA = "0xFFDB84", Offset = "0xFFDB84", VA = "0xFFDB84")]
	public void SetDelayCloseTimeAndShowUI(Action callback, bool showLoserAudio = false)
	{
	}

	[Token(Token = "0x600F4DA")]
	[Address(RVA = "0xFFDC18", Offset = "0xFFDC18", VA = "0xFFDC18", Slot = "31")]
	protected virtual void ShowUI(bool showLoserAudio = false)
	{
	}

	[Token(Token = "0x600F4DB")]
	[Address(RVA = "0xFFDD78", Offset = "0xFFDD78", VA = "0xFFDD78")]
	private IEnumerator ProcessUpdateCloseTime()
	{
		return null;
	}

	[Token(Token = "0x600F4DC")]
	[Address(RVA = "0xFFDE4C", Offset = "0xFFDE4C", VA = "0xFFDE4C")]
	private void SendGameEnd()
	{
	}

	[Token(Token = "0x600F4DD")]
	[Address(RVA = "0xFFDF90", Offset = "0xFFDF90", VA = "0xFFDF90")]
	public void OnShowResultClick()
	{
	}
}
