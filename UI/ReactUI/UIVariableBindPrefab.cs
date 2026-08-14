using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CD8")]
public sealed class UIVariableBindPrefab : UIVariableBind
{
	[Token(Token = "0x400681F")]
	[FieldOffset(Offset = "0x0")]
	private static ResourceManager m_Res;

	[Token(Token = "0x4006820")]
	[FieldOffset(Offset = "0x1C")]
	private string prefabResourceID;

	[Token(Token = "0x4006821")]
	[FieldOffset(Offset = "0x20")]
	private string prefabScale;

	[Token(Token = "0x4006822")]
	[FieldOffset(Offset = "0x24")]
	private string prefabRotateYaw;

	[Token(Token = "0x4006823")]
	[FieldOffset(Offset = "0x28")]
	private string prefabRotatePitch;

	[Token(Token = "0x4006824")]
	[FieldOffset(Offset = "0x2C")]
	private UIVariable prefabResIDVariable;

	[Token(Token = "0x4006825")]
	[FieldOffset(Offset = "0x30")]
	private UIVariable prefabScaleVariable;

	[Token(Token = "0x4006826")]
	[FieldOffset(Offset = "0x34")]
	private UIVariable prefabRotYawVariable;

	[Token(Token = "0x4006827")]
	[FieldOffset(Offset = "0x38")]
	private UIVariable prefabRotPitchVariable;

	[Token(Token = "0x4006828")]
	[FieldOffset(Offset = "0x3C")]
	protected Vector3 m_childScale;

	[Token(Token = "0x4006829")]
	[FieldOffset(Offset = "0x48")]
	protected Vector3 m_childEmuler;

	[Token(Token = "0x400682A")]
	[FieldOffset(Offset = "0x54")]
	private GameObject m_instObject;

	[Token(Token = "0x400682B")]
	[FieldOffset(Offset = "0x58")]
	private float m_maxDuration;

	[Token(Token = "0x400682C")]
	[FieldOffset(Offset = "0x5C")]
	private float m_nextReplayTime;

	[Token(Token = "0x400682D")]
	[FieldOffset(Offset = "0x60")]
	private Renderer[] CacheRenders;

	[Token(Token = "0x400682E")]
	[FieldOffset(Offset = "0x64")]
	public Color m_color;

	[Token(Token = "0x6006190")]
	[Address(RVA = "0x31659C8", Offset = "0x31659C8", VA = "0x31659C8")]
	public UIVariableBindPrefab()
	{
	}

	[Token(Token = "0x6006191")]
	[Address(RVA = "0x3165AE4", Offset = "0x3165AE4", VA = "0x3165AE4", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x6006192")]
	[Address(RVA = "0x3165EB0", Offset = "0x3165EB0", VA = "0x3165EB0", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x6006193")]
	[Address(RVA = "0x31661CC", Offset = "0x31661CC", VA = "0x31661CC")]
	private void RefreshScaleRot()
	{
	}

	[Token(Token = "0x6006194")]
	[Address(RVA = "0x31663D8", Offset = "0x31663D8", VA = "0x31663D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6006195")]
	[Address(RVA = "0x3166500", Offset = "0x3166500", VA = "0x3166500")]
	private void RefreshPrefab()
	{
	}

	[Token(Token = "0x6006196")]
	[Address(RVA = "0x3166B24", Offset = "0x3166B24", VA = "0x3166B24")]
	private void ApplyColor()
	{
	}
}
