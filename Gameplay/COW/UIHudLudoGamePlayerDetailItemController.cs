using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002198")]
public class UIHudLudoGamePlayerDetailItemController : MonoBehaviour
{
	[Token(Token = "0x2002199")]
	private sealed class _003CCoProcessBar_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D287")]
		[FieldOffset(Offset = "0x8")]
		internal float from;

		[Token(Token = "0x400D288")]
		[FieldOffset(Offset = "0xC")]
		internal float to;

		[Token(Token = "0x400D289")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudLudoGamePlayerDetailItemController _0024this;

		[Token(Token = "0x400D28A")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D28B")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D28C")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001024")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B26D")]
			[Address(RVA = "0xFF67FC", Offset = "0xFF67FC", VA = "0xFF67FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001025")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B26E")]
			[Address(RVA = "0xFF6804", Offset = "0xFF6804", VA = "0xFF6804", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B26B")]
		[Address(RVA = "0xFF6570", Offset = "0xFF6570", VA = "0xFF6570")]
		public _003CCoProcessBar_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B26C")]
		[Address(RVA = "0xFF6578", Offset = "0xFF6578", VA = "0xFF6578", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B26F")]
		[Address(RVA = "0xFF680C", Offset = "0xFF680C", VA = "0xFF680C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B270")]
		[Address(RVA = "0xFF6820", Offset = "0xFF6820", VA = "0xFF6820", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D27B")]
	[FieldOffset(Offset = "0xC")]
	public UILabel PlayerName;

	[Token(Token = "0x400D27C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel PlayerIndex;

	[Token(Token = "0x400D27D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite GameProcessBar;

	[Token(Token = "0x400D27E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HeadBg;

	[Token(Token = "0x400D27F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LocalPlayerBg;

	[Token(Token = "0x400D280")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GameProcessLabel;

	[Token(Token = "0x400D281")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OfflineState;

	[Token(Token = "0x400D282")]
	[FieldOffset(Offset = "0x28")]
	public GameObject QuitState;

	[Token(Token = "0x400D283")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TrustState;

	[Token(Token = "0x400D284")]
	[FieldOffset(Offset = "0x30")]
	public uint m_PlayerIndex;

	[Token(Token = "0x400D285")]
	[FieldOffset(Offset = "0x34")]
	private int m_MostCloseNode;

	[Token(Token = "0x400D286")]
	[FieldOffset(Offset = "0x38")]
	private int m_AllNode;

	[Token(Token = "0x600B264")]
	[Address(RVA = "0xFF63C8", Offset = "0xFF63C8", VA = "0xFF63C8")]
	public UIHudLudoGamePlayerDetailItemController()
	{
	}

	[Token(Token = "0x600B265")]
	[Address(RVA = "0xFF63D0", Offset = "0xFF63D0", VA = "0xFF63D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600B266")]
	[Address(RVA = "0xFF5454", Offset = "0xFF5454", VA = "0xFF5454")]
	public void InitGameProcess(int Node, int AllNode)
	{
	}

	[Token(Token = "0x600B267")]
	[Address(RVA = "0xFF55FC", Offset = "0xFF55FC", VA = "0xFF55FC")]
	public void SetBaseInfo(string name, uint idx, bool isLocalPlayer, Color c)
	{
	}

	[Token(Token = "0x600B268")]
	[Address(RVA = "0xFF57EC", Offset = "0xFF57EC", VA = "0xFF57EC")]
	public void UpdateState(IHDGEDLCEHF state)
	{
	}

	[Token(Token = "0x600B269")]
	[Address(RVA = "0xFF60C4", Offset = "0xFF60C4", VA = "0xFF60C4")]
	public void OnProcessChange(int Node)
	{
	}

	[Token(Token = "0x600B26A")]
	[Address(RVA = "0xFF644C", Offset = "0xFF644C", VA = "0xFF644C")]
	private IEnumerator CoProcessBar(float from, float to)
	{
		return null;
	}
}
