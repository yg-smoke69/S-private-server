using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GCommon.UGCUI;

[Token(Token = "0x20040FC")]
public class UGCUIBehaviour : MonoBehaviour
{
	[Token(Token = "0x401B4E8")]
	[FieldOffset(Offset = "0xC")]
	protected uint m_UniqueID;

	[Token(Token = "0x401B4E9")]
	[FieldOffset(Offset = "0x10")]
	protected uint m_Hierarchy;

	[Token(Token = "0x401B4EA")]
	[FieldOffset(Offset = "0x14")]
	public UnityAction onHierarchyChanged;

	[Token(Token = "0x17001D16")]
	public uint UniqueID
	{
		[Token(Token = "0x601A865")]
		[Address(RVA = "0x2C8AC60", Offset = "0x2C8AC60", VA = "0x2C8AC60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601A866")]
		[Address(RVA = "0x2C8AC68", Offset = "0x2C8AC68", VA = "0x2C8AC68")]
		set
		{
		}
	}

	[Token(Token = "0x17001D17")]
	public uint Hierarchy
	{
		[Token(Token = "0x601A867")]
		[Address(RVA = "0x2C8AC78", Offset = "0x2C8AC78", VA = "0x2C8AC78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601A868")]
		[Address(RVA = "0x2C8AC80", Offset = "0x2C8AC80", VA = "0x2C8AC80")]
		protected set
		{
		}
	}

	[Token(Token = "0x601A864")]
	[Address(RVA = "0x2C8AC58", Offset = "0x2C8AC58", VA = "0x2C8AC58")]
	public UGCUIBehaviour()
	{
	}

	[Token(Token = "0x601A869")]
	[Address(RVA = "0x2C8ACC8", Offset = "0x2C8ACC8", VA = "0x2C8ACC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A86A")]
	[Address(RVA = "0x2C8ACD8", Offset = "0x2C8ACD8", VA = "0x2C8ACD8")]
	public void SetParent(Transform parent, bool worldPositionStays = true)
	{
	}

	[Token(Token = "0x601A86B")]
	[Address(RVA = "0x2C8AEAC", Offset = "0x2C8AEAC", VA = "0x2C8AEAC", Slot = "4")]
	protected virtual void OnHierarchyDirty()
	{
	}

	[Token(Token = "0x601A86C")]
	[Address(RVA = "0x2C8AFFC", Offset = "0x2C8AFFC", VA = "0x2C8AFFC", Slot = "5")]
	protected virtual void OnInternalDestroy()
	{
	}
}
