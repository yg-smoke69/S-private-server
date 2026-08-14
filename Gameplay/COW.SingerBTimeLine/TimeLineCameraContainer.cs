using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B6D")]
public class TimeLineCameraContainer : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4006116")]
	[FieldOffset(Offset = "0xC")]
	public Transform MoiveCameraTransform;

	[Token(Token = "0x4006117")]
	[FieldOffset(Offset = "0x10")]
	public Transform StarFallingCameraTransform;

	[Token(Token = "0x4006118")]
	[FieldOffset(Offset = "0x14")]
	public Transform FlyToChannelCutsceneTimeLineCameraTransform;

	[Token(Token = "0x4006119")]
	[FieldOffset(Offset = "0x18")]
	public Transform OutChannelCutsceneTimeLineCameraTransform;

	[Token(Token = "0x400611A")]
	[FieldOffset(Offset = "0x1C")]
	public List<Transform> CallDanceCutsceneTimeLineCameraTransform;

	[Token(Token = "0x400611B")]
	[FieldOffset(Offset = "0x20")]
	public PlayableDirector FlyToChannelCutsceneTimeLine;

	[Token(Token = "0x400611C")]
	[FieldOffset(Offset = "0x24")]
	public PlayableDirector OutChannelCutsceneTimeLine;

	[Token(Token = "0x400611D")]
	[FieldOffset(Offset = "0x28")]
	public List<PlayableDirector> CallDanceCutsceneTimeLine;

	[Token(Token = "0x400611E")]
	[FieldOffset(Offset = "0x2C")]
	private ETimeLineCameraType m_CurBackMovieCameraType;

	[Token(Token = "0x400611F")]
	[FieldOffset(Offset = "0x30")]
	private ETimeLineCameraType m_CurCameraType;

	[Token(Token = "0x4006120")]
	[FieldOffset(Offset = "0x34")]
	private Transform m_CurCameraTrackContainer;

	[Token(Token = "0x4006121")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsCameraFocusPlayer;

	[Token(Token = "0x4006122")]
	[FieldOffset(Offset = "0x3C")]
	private Player m_LocalPlayer;

	[Token(Token = "0x60056BF")]
	[Address(RVA = "0x20EC044", Offset = "0x20EC044", VA = "0x20EC044")]
	public TimeLineCameraContainer()
	{
	}

	[Token(Token = "0x60056C0")]
	[Address(RVA = "0x20EC0DC", Offset = "0x20EC0DC", VA = "0x20EC0DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60056C1")]
	[Address(RVA = "0x20EC224", Offset = "0x20EC224", VA = "0x20EC224")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60056C2")]
	[Address(RVA = "0x20EC36C", Offset = "0x20EC36C", VA = "0x20EC36C")]
	private void CancleMovieCamera(object[] data)
	{
	}

	[Token(Token = "0x60056C3")]
	[Address(RVA = "0x20EC8DC", Offset = "0x20EC8DC", VA = "0x20EC8DC")]
	private void OnTimeLineCameraTypeChage(object[] data)
	{
	}

	[Token(Token = "0x60056C4")]
	[Address(RVA = "0x20ECA20", Offset = "0x20ECA20", VA = "0x20ECA20")]
	private bool IsCallDanceCutsceneCamera(ETimeLineCameraType cameraType)
	{
		return default(bool);
	}

	[Token(Token = "0x60056C5")]
	[Address(RVA = "0x20EC384", Offset = "0x20EC384", VA = "0x20EC384")]
	private void SwitchCamera(ETimeLineCameraType targetType, bool isNeedPlayCameraTimeLine = true)
	{
	}

	[Token(Token = "0x60056C6")]
	[Address(RVA = "0x20ECBD0", Offset = "0x20ECBD0", VA = "0x20ECBD0")]
	protected void PlayPlayerCutsceneCamera(PlayableDirector cameraTimeLine, Transform cameraTransform, bool isFocusPlayer = true)
	{
	}

	[Token(Token = "0x60056C7")]
	[Address(RVA = "0x20ECA44", Offset = "0x20ECA44", VA = "0x20ECA44")]
	private void PlayCallDanceCutsceneWithoutSwitchCamera(ETimeLineCameraType cameraType)
	{
	}

	[Token(Token = "0x60056C8")]
	[Address(RVA = "0x20ECD50", Offset = "0x20ECD50", VA = "0x20ECD50", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60056C9")]
	[Address(RVA = "0x20ECE1C", Offset = "0x20ECE1C", VA = "0x20ECE1C", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60056CA")]
	[Address(RVA = "0x20ECE2C", Offset = "0x20ECE2C", VA = "0x20ECE2C", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60056CB")]
	[Address(RVA = "0x20ECF80", Offset = "0x20ECF80", VA = "0x20ECF80", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x60056CC")]
	[Address(RVA = "0x20ECF88", Offset = "0x20ECF88", VA = "0x20ECF88", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}
}
