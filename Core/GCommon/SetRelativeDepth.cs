using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004119")]
public class SetRelativeDepth : MonoBehaviour
{
	[Token(Token = "0x200411A")]
	public enum PositionType
	{
		[Token(Token = "0x401B58A")]
		Above,
		[Token(Token = "0x401B58B")]
		Behind
	}

	[Token(Token = "0x401B582")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget widget;

	[Token(Token = "0x401B583")]
	[FieldOffset(Offset = "0x10")]
	public PositionType position;

	[Token(Token = "0x401B584")]
	[FieldOffset(Offset = "0x14")]
	public bool m_ChangeChildren;

	[Token(Token = "0x401B585")]
	[FieldOffset(Offset = "0x18")]
	private int sortingOrder;

	[Token(Token = "0x401B586")]
	[FieldOffset(Offset = "0x1C")]
	private int renderQueue;

	[Token(Token = "0x401B587")]
	private const bool updateEveryFrame = true;

	[Token(Token = "0x401B588")]
	[FieldOffset(Offset = "0x20")]
	private List<Renderer> _CachedChildrenRenderers;

	[Token(Token = "0x17001D4A")]
	private List<Renderer> CachedChildrenRenderers
	{
		[Token(Token = "0x601A95B")]
		[Address(RVA = "0x323413C", Offset = "0x323413C", VA = "0x323413C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A95A")]
	[Address(RVA = "0x3234134", Offset = "0x3234134", VA = "0x3234134")]
	public SetRelativeDepth()
	{
	}

	[Token(Token = "0x601A95C")]
	[Address(RVA = "0x323433C", Offset = "0x323433C", VA = "0x323433C")]
	private void Start()
	{
	}

	[Token(Token = "0x601A95D")]
	[Address(RVA = "0x3234344", Offset = "0x3234344", VA = "0x3234344")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x601A95E")]
	[Address(RVA = "0x323434C", Offset = "0x323434C", VA = "0x323434C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601A95F")]
	[Address(RVA = "0x3232FB4", Offset = "0x3232FB4", VA = "0x3232FB4")]
	public void Refresh(bool isForce = false)
	{
	}
}
