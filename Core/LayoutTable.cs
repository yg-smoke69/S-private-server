using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D22")]
public class LayoutTable : BaseTableItem
{
	[Token(Token = "0x401139A")]
	[FieldOffset(Offset = "0x14")]
	private ELayoutType m_LayoutType;

	[Token(Token = "0x401139B")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_StartTopLeftPos;

	[Token(Token = "0x401139C")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject[] m_GOs;

	[Token(Token = "0x401139D")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 m_Padding;

	[Token(Token = "0x401139E")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ExecuteOnStart;

	[Token(Token = "0x401139F")]
	[FieldOffset(Offset = "0x2C")]
	private List<ILayoutTableItem> m_Items;

	[Token(Token = "0x40113A0")]
	[FieldOffset(Offset = "0x30")]
	private float _003CTotalWidthForVertical_003Ek__BackingField;

	[Token(Token = "0x40113A1")]
	[FieldOffset(Offset = "0x34")]
	private float _003CTotalHeightForVertical_003Ek__BackingField;

	[Token(Token = "0x40113A2")]
	[FieldOffset(Offset = "0x38")]
	private float _003CTotalHeightForHorizontal_003Ek__BackingField;

	[Token(Token = "0x40113A3")]
	[FieldOffset(Offset = "0x3C")]
	private float _003CTotalWidthForHorizontal_003Ek__BackingField;

	[Token(Token = "0x17001359")]
	public float TotalWidthForVertical
	{
		[Token(Token = "0x6012DE1")]
		[Address(RVA = "0x3111CB8", Offset = "0x3111CB8", VA = "0x3111CB8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012DE2")]
		[Address(RVA = "0x3111CC0", Offset = "0x3111CC0", VA = "0x3111CC0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700135A")]
	public float TotalHeightForVertical
	{
		[Token(Token = "0x6012DE3")]
		[Address(RVA = "0x3111CC8", Offset = "0x3111CC8", VA = "0x3111CC8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012DE4")]
		[Address(RVA = "0x3111CD0", Offset = "0x3111CD0", VA = "0x3111CD0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700135B")]
	public float TotalHeightForHorizontal
	{
		[Token(Token = "0x6012DE5")]
		[Address(RVA = "0x3111CD8", Offset = "0x3111CD8", VA = "0x3111CD8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012DE6")]
		[Address(RVA = "0x3111CE0", Offset = "0x3111CE0", VA = "0x3111CE0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700135C")]
	public float TotalWidthForHorizontal
	{
		[Token(Token = "0x6012DE7")]
		[Address(RVA = "0x3111CE8", Offset = "0x3111CE8", VA = "0x3111CE8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012DE8")]
		[Address(RVA = "0x3111CF0", Offset = "0x3111CF0", VA = "0x3111CF0")]
		private set
		{
		}
	}

	[Token(Token = "0x6012DE0")]
	[Address(RVA = "0x3111C2C", Offset = "0x3111C2C", VA = "0x3111C2C")]
	public LayoutTable()
	{
	}

	[Token(Token = "0x6012DE9")]
	[Address(RVA = "0x3111CF8", Offset = "0x3111CF8", VA = "0x3111CF8")]
	public GameObject[] GetGos()
	{
		return null;
	}

	[Token(Token = "0x6012DEA")]
	[Address(RVA = "0x3111D00", Offset = "0x3111D00", VA = "0x3111D00")]
	public List<ILayoutTableItem> GetItems()
	{
		return null;
	}

	[Token(Token = "0x6012DEB")]
	[Address(RVA = "0x3111D08", Offset = "0x3111D08", VA = "0x3111D08")]
	private void Start()
	{
	}

	[Token(Token = "0x6012DEC")]
	[Address(RVA = "0x3112648", Offset = "0x3112648", VA = "0x3112648", Slot = "8")]
	public override void Init()
	{
	}

	[Token(Token = "0x6012DED")]
	[Address(RVA = "0x3112930", Offset = "0x3112930", VA = "0x3112930", Slot = "9")]
	public override void UnInit()
	{
	}

	[Token(Token = "0x6012DEE")]
	[Address(RVA = "0x3112B40", Offset = "0x3112B40", VA = "0x3112B40", Slot = "11")]
	protected override void EditorExecute()
	{
	}

	[Token(Token = "0x6012DEF")]
	[Address(RVA = "0x3111D54", Offset = "0x3111D54", VA = "0x3111D54")]
	public void Execute()
	{
	}

	[Token(Token = "0x6012DF0")]
	[Address(RVA = "0x3112E10", Offset = "0x3112E10", VA = "0x3112E10", Slot = "10")]
	public override Vector2 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
