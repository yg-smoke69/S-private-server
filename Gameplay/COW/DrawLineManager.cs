using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002284")]
public class DrawLineManager : MonoSingleton<DrawLineManager>
{
	[Token(Token = "0x400D806")]
	[FieldOffset(Offset = "0xC")]
	public List<Rect> EditorUIRectList;

	[Token(Token = "0x400D807")]
	[FieldOffset(Offset = "0x10")]
	public MapEditorType CurrentMapEditorType;

	[Token(Token = "0x400D808")]
	[FieldOffset(Offset = "0x14")]
	public bool IsMapOpen;

	[Token(Token = "0x400D809")]
	[FieldOffset(Offset = "0x15")]
	public bool OpenDrawFunction;

	[Token(Token = "0x400D80A")]
	[FieldOffset(Offset = "0x18")]
	private int MaxCtrlZCount;

	[Token(Token = "0x400D80B")]
	[FieldOffset(Offset = "0x1C")]
	private int ZPostion;

	[Token(Token = "0x400D80C")]
	[FieldOffset(Offset = "0x20")]
	private Color CurrentColor;

	[Token(Token = "0x400D80D")]
	[FieldOffset(Offset = "0x30")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x400D80E")]
	[FieldOffset(Offset = "0x34")]
	private Transform LinesTrans;

	[Token(Token = "0x400D80F")]
	[FieldOffset(Offset = "0x38")]
	private Camera Camera;

	[Token(Token = "0x400D810")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 position;

	[Token(Token = "0x400D811")]
	[FieldOffset(Offset = "0x48")]
	private int index;

	[Token(Token = "0x400D812")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_StartPos;

	[Token(Token = "0x400D813")]
	[FieldOffset(Offset = "0x58")]
	private int LengthOfLineRenderer;

	[Token(Token = "0x400D814")]
	[FieldOffset(Offset = "0x5C")]
	private LineRenderer m_CurrentlLine;

	[Token(Token = "0x400D815")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> LineList;

	[Token(Token = "0x400D816")]
	[FieldOffset(Offset = "0x64")]
	public Stack<GameObject> LinesUndo;

	[Token(Token = "0x400D817")]
	[FieldOffset(Offset = "0x68")]
	private int pointCount;

	[Token(Token = "0x400D818")]
	[FieldOffset(Offset = "0x6C")]
	private float angle;

	[Token(Token = "0x400D819")]
	[FieldOffset(Offset = "0x70")]
	private List<Vector3> points;

	[Token(Token = "0x400D81A")]
	[FieldOffset(Offset = "0x74")]
	private LineRenderer m_HeadLineRendererLeft;

	[Token(Token = "0x400D81B")]
	[FieldOffset(Offset = "0x78")]
	private LineRenderer m_HeadLineRendererRight;

	[Token(Token = "0x600BD42")]
	[Address(RVA = "0x1C95168", Offset = "0x1C95168", VA = "0x1C95168")]
	public DrawLineManager()
	{
	}

	[Token(Token = "0x600BD43")]
	[Address(RVA = "0x1C95350", Offset = "0x1C95350", VA = "0x1C95350", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x600BD44")]
	[Address(RVA = "0x1C95B54", Offset = "0x1C95B54", VA = "0x1C95B54")]
	private void Update()
	{
	}

	[Token(Token = "0x600BD45")]
	[Address(RVA = "0x1C974A4", Offset = "0x1C974A4", VA = "0x1C974A4")]
	private void ResetLine()
	{
	}

	[Token(Token = "0x600BD46")]
	[Address(RVA = "0x1C9732C", Offset = "0x1C9732C", VA = "0x1C9732C")]
	public void Undo()
	{
	}

	[Token(Token = "0x600BD47")]
	[Address(RVA = "0x1C975E4", Offset = "0x1C975E4", VA = "0x1C975E4")]
	private void ResycleStack()
	{
	}

	[Token(Token = "0x600BD48")]
	[Address(RVA = "0x1C977E4", Offset = "0x1C977E4", VA = "0x1C977E4")]
	private void InstantiateLine()
	{
	}

	[Token(Token = "0x600BD49")]
	[Address(RVA = "0x1C95EBC", Offset = "0x1C95EBC", VA = "0x1C95EBC")]
	private void ProcessDraw(bool MouseHoverOnButton = false)
	{
	}

	[Token(Token = "0x600BD4A")]
	[Address(RVA = "0x1C96CA0", Offset = "0x1C96CA0", VA = "0x1C96CA0")]
	private void ProcessDrawArrowLine(bool MouseHoverOnButton = false)
	{
	}

	[Token(Token = "0x600BD4B")]
	[Address(RVA = "0x1C96220", Offset = "0x1C96220", VA = "0x1C96220")]
	private void ProcessLine(bool MouseHoverOnButton = false)
	{
	}

	[Token(Token = "0x600BD4C")]
	[Address(RVA = "0x1C96614", Offset = "0x1C96614", VA = "0x1C96614")]
	private void ProcessDrawCircle(bool MouseHoverOnButton = false)
	{
	}

	[Token(Token = "0x600BD4D")]
	[Address(RVA = "0x1C97DE4", Offset = "0x1C97DE4", VA = "0x1C97DE4")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600BD4E")]
	[Address(RVA = "0x1C97E74", Offset = "0x1C97E74", VA = "0x1C97E74")]
	public void Clear(bool resetstate = true)
	{
	}

	[Token(Token = "0x600BD4F")]
	[Address(RVA = "0x1C980C4", Offset = "0x1C980C4", VA = "0x1C980C4")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
