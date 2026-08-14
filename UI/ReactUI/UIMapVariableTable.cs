using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CBA")]
public sealed class UIMapVariableTable : MonoBehaviour
{
	[Token(Token = "0x4006783")]
	[FieldOffset(Offset = "0xC")]
	private UIMapVariable[] mapVariables;

	[Token(Token = "0x4006784")]
	[FieldOffset(Offset = "0x10")]
	private UIVariableTable varTable;

	[Token(Token = "0x17000812")]
	public UIMapVariable[] Variables
	{
		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x315C68C", Offset = "0x315C68C", VA = "0x315C68C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000813")]
	public UIVariableTable VarTable
	{
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x315C694", Offset = "0x315C694", VA = "0x315C694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60060DD")]
	[Address(RVA = "0x315C684", Offset = "0x315C684", VA = "0x315C684")]
	public UIMapVariableTable()
	{
	}

	[Token(Token = "0x60060E0")]
	[Address(RVA = "0x315C748", Offset = "0x315C748", VA = "0x315C748")]
	public void Init()
	{
	}

	[Token(Token = "0x60060E1")]
	[Address(RVA = "0x315C830", Offset = "0x315C830", VA = "0x315C830")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60060E2")]
	[Address(RVA = "0x315C8C0", Offset = "0x315C8C0", VA = "0x315C8C0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60060E3")]
	[Address(RVA = "0x315CA28", Offset = "0x315CA28", VA = "0x315CA28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60060E4")]
	[Address(RVA = "0x315CA98", Offset = "0x315CA98", VA = "0x315CA98")]
	public UIMapVariable GetMapVariable(int index)
	{
		return null;
	}

	[Token(Token = "0x60060E5")]
	[Address(RVA = "0x315CAE0", Offset = "0x315CAE0", VA = "0x315CAE0")]
	public void SetSrcValue(int srcIdx, int mapVarIdx)
	{
	}

	[Token(Token = "0x60060E6")]
	[Address(RVA = "0x315CB88", Offset = "0x315CB88", VA = "0x315CB88")]
	public void AddDefaultVariable()
	{
	}
}
