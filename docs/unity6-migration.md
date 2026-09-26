# Unity 6 전환 기록

현재 기준 버전은 **6000.3.22f1**입니다. 원본은 2020.3.8f1입니다.

## 반영한 변경

- Unity가 변환한 패키지와 프로젝트 설정을 유지합니다.
- 점프 예제는 Rigidbody.linearVelocity를 사용합니다.
- TMP 샘플의 UV0를 Vector4 배열로 처리합니다.
- 004 실습 씬을 빌드 씬 목록에 등록했습니다. Unity 6의 File > Build Profiles에서 확인합니다.
- 타이틀 예제의 Space 입력은 004-21-02_KeyFrameAnimation으로 이동합니다. Inspector의 Next Scene Name으로 변경할 수 있습니다.

## 입력 및 렌더링

현재 예제는 기존 Input Manager를 사용합니다. Active Input Handling을 Input System Package만 사용하도록 바꾸면 기존 Input.GetAxis/GetButton 코드가 동작하지 않습니다. 입력 시스템 전환은 별도 실습으로 진행합니다.
기존 머티리얼과 장면을 유지하며 렌더 파이프라인을 새로 전환하지 않았습니다.

## 실행 확인 순서

1. Unity에서 스크립트 재컴파일이 끝난 뒤 Console을 확인합니다.
2. 004-04_02_Jump: Space로 점프를 확인합니다.
3. 004-15-01_LoadScene: UI로 두 장면 사이 전환을 확인합니다.
4. 004-21-01_TitleScreen: Space로 키프레임 장면 전환을 확인합니다.
5. 004-18 UI와 004-20 애니메이션의 표시/조작을 확인합니다.

정적 점검은 완료했으나 전체 장면의 Play Mode 동작과 빌드 실행은 아직 검증하지 않았습니다.
