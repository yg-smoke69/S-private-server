using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CBC")]
public abstract class UIVariableBind : MonoBehaviour
{
	[Token(Token = "0x4006791")]
	[FieldOffset(Offset = "0xC")]
	private UIVariableTable variableTable;

	[Token(Token = "0x4006792")]
	[FieldOffset(Offset = "0x10")]
	private bool isInited;

	[Token(Token = "0x4006793")]
	[FieldOffset(Offset = "0x14")]
	private UIVariableTable bindTable;

	[Token(Token = "0x4006794")]
	[FieldOffset(Offset = "0x18")]
	private UIVariableTable _003CVariableTable_003Ek__BackingField;

	[Token(Token = "0x4006795")]
	[FieldOffset(Offset = "0x0")]
	private static string _markCustomParentVariableTable;

	[Token(Token = "0x17000818")]
	public UIVariableTable VariableTable
	{
		[Token(Token = "0x6006110")]
		[Address(RVA = "0x315DDB4", Offset = "0x315DDB4", VA = "0x315DDB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006111")]
		[Address(RVA = "0x315DDBC", Offset = "0x315DDBC", VA = "0x315DDBC")]
		private set
		{
		}
	}

	[Token(Token = "0x600610F")]
	[Address(RVA = "0x3157278", Offset = "0x3157278", VA = "0x3157278")]
	protected UIVariableBind()
	{
	}

	[Token(Token = "0x6006112")]
	[Address(RVA = "0x3157C10", Offset = "0x3157C10", VA = "0x3157C10", Slot = "4")]
	internal virtual void Init()
	{
	}

	[Token(Token = "0x6006113")]
	[Address(RVA = "0x3157D08", Offset = "0x3157D08", VA = "0x3157D08")]
	public UIVariable FindVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x6006114")]
	[Address(RVA = "0x315DE80", Offset = "0x315DE80", VA = "0x315DE80")]
	private UIVariableTable FindCustomParentTable(string name)
	{
		return null;
	}

	[Token(Token = "0x6006115")]
	[Address(RVA = "0x3157AD8", Offset = "0x3157AD8", VA = "0x3157AD8", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6006116")]
	[Address(RVA = "0x315E118", Offset = "0x315E118", VA = "0x315E118", Slot = "6")]
	protected virtual void BindVariables()
	{
	}

	[Token(Token = "0x6006117")]
	[Address(RVA = "0x315E11C", Offset = "0x315E11C", VA = "0x315E11C", Slot = "7")]
	protected virtual void UnbindVariables()
	{
	}

	[Token(Token = "0x6006118")]
	[Address(RVA = "0x3157B3C", Offset = "0x3157B3C", VA = "0x3157B3C", Slot = "8")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6006119")]
	[Address(RVA = "0x3157798", Offset = "0x3157798", VA = "0x3157798", Slot = "9")]
	protected virtual void OnValidate()
	{
	}

	[Token(Token = "0x600611A")]
	[Address(RVA = "0x315DDC4", Offset = "0x315DDC4", VA = "0x315DDC4")]
	private void FindVarTable()
	{
	}
}
