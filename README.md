# **ODCC(Object-Data-Component Container)란?**

ODCC는 Unity에서 객체와 컴포넌트를 효과적으로 관리하기 위한 프레임워크입니다.
ODCC는 모든 클래스들을 **Object**, **Data**, **Component** 세 가지 유형으로 나누어 각각 독립적이고 명확한 역할을 수행하도록 설계되었습니다. 이를 통해 클래스 간의 역할을 명확히 구분하고, 복잡한 프로젝트에서도 유지보수와 확장성을 높일 수 있는 구조적 개발 방식을 촉진합니다.

- **Object**: 게임 오브젝트 자체를 관리하고, 이 오브젝트의 계층 구조와 자식-부모 관계를 정의합니다. 이를 통해 게임의 주요 엔티티를 체계적으로 관리할 수 있습니다.
- **Data**: 각 오브젝트의 상태를 표현하고, 관련된 데이터를 저장합니다. 데이터는 오브젝트가 가지는 속성과 상태를 정의하며, 게임 로직에서 중요한 정보를 제공합니다.
- **Component**: 오브젝트의 행동과 기능을 수행하는 모듈로, 오브젝트에 특정 기능적 요소를 부여합니다. 각 컴포넌트는 독립적인 기능을 담당하며, 필요에 따라 오브젝트에 추가하거나 제거할 수 있어 유연한 기능 확장이 가능합니다.

ODCC는 프로젝트가 커질수록 늘어나는 GameObject와 복잡해지는 Script를 체계적으로 관리할 수 있는 강력한 설계 규칙을 제공합니다. 이를 통해 클래스의 역할을 명확히 구분하고, 유지보수와 확장성을 높일 수 있는 구조적 개발 방식을 촉진합니다. 특히, ODCC는 객체 간의 관계를 명확히 정의하여 계층 구조를 관리하고, 객체의 상태와 기능을 분리함으로써 코드를 더 명확하고 읽기 쉽게 만듭니다.

또한 ODCC는 여러 편리한 도구와 시스템을 포함하여, **객체 검색** 및 **쿼리 빌더**, **반복 작업 관리 시스템** 등을 통해 특정 조건에 맞는 오브젝트를 손쉽게 필터링하고 반복 작업을 관리할 수 있습니다. 이러한 기능들은 복잡한 씬에서도 필요한 객체를 효율적으로 검색하고 작업을 수행할 수 있게 돕습니다.

### 주요 기능 및 장점
- **구조적 관리**: 오브젝트, 데이터, 컴포넌트 간의 명확한 역할 분리로 인해 시스템의 유지보수성과 이해도가 높아집니다.
- **효율적 쿼리 시스템**: 조건에 맞는 객체를 손쉽게 검색할 수 있는 기능을 제공하여, 복잡한 씬에서도 필요한 객체를 쉽게 찾을 수 있습니다.
- **모듈화된 개발**: 독립적인 기능 모듈로 구성된 컴포넌트는 코드 재사용성을 높이고, 필요에 따라 기능을 쉽게 추가하거나 변경할 수 있게 돕습니다.

ODCC는 Odin Inspector and Serializer 같은 Unity 에셋을 이용하여 개발의 편의성과 디버깅 경험을 향상시키고, 최신 Unity 릴리즈를 목표로 지속적으로 업데이트되고 있습니다.

---
### 주의
- 되도록 Unity 최신 릴리즈를 타겟으로 합니다.
- 이 프레임워크는 자주 업데이트 되며, 완전히 검증되지 않았습니다.
- 이 도구들이 정상적인 동작을 위해서는 [Odin Inspector and Serializer]를 필요로 합니다. 해당 에셋은 별도로 받으셔야 합니다.
이를 사용하지 않는다면 일부 수정이 필요합니다.


# 주요 폴더 및 스크립트 
## 관리 영역

1. **OdccManager** (핵심 관리 클래스)
   - ODCC의 초기화, 트리 및 반복 시스템 관리, 씬 로딩 전 설정을 수행하는 핵심 클래스입니다. 모든 구성 요소의 중앙 제어 역할을 하며 싱글톤 패턴으로 관리됩니다.

2. **OdccContainerTree** (오브젝트 계층 구조 관리)
   - 오브젝트 간의 계층 구조를 트리 형태로 관리하며, 각 오브젝트와 그 관계를 정의하고 트리의 노드로 관리합니다. ODCC 시스템의 기초적인 오브젝트 구조와 연관된 모든 관계를 정의합니다.

3. **QuerySystem** 및 **QuerySystemBuilder** (객체 검색 및 쿼리 빌더)
   - 특정 조건에 맞는 객체를 효율적으로 필터링하고 수집하기 위한 시스템입니다. 씬, 부모, 자식 범위를 정의하여 객체를 검색하며, 쿼리 빌더를 통해 다양한 필터링 조건을 설정할 수 있습니다.

4. **OdccForeach** (반복 작업 관리 시스템)
   - 특정 조건에 따라 필터링된 객체에 대해 반복 작업을 수행하는 기능을 제공합니다. 비동기 작업과 `foreachAction`을 통해 각 객체의 Update와 LateUpdate를 수행하여 효율적인 처리를 가능하게 합니다.

5. **OdccQueryCollector** (쿼리 결과 수집 및 관리)
   - 쿼리된 `ObjectBehaviour` 객체를 수집하고, 생명주기를 관리하며 루퍼 및 액션 이벤트를 처리합니다. 수집된 항목을 기반으로 특정 작업을 반복하거나 처리할 수 있는 기능을 제공합니다.

6. **OdccQueryLooper** (비동기 루프 작업 관리)
   - `OdccQueryCollector`로부터 수집된 항목을 기반으로 비동기 루프 작업을 수행하며, 각 항목에 대해 반복 작업을 관리합니다. `RunForeachStruct`를 사용해 반복 작업을 정의하고, 필요에 따라 항목을 추가하거나 제거할 수 있습니다.

## 구현 영역

1. **ObjectBehaviour** (주요 오브젝트 관리 클래스)
   - ODCC 시스템의 주요 오브젝트를 관리하는 클래스입니다. 이 클래스는 `ContainerObject`를 통해 계층 구조를 정의하고, 객체의 컴포넌트와 자식을 관리하며 편집기에서 초기화와 유효성 검사를 수행합니다.

2. **OCBehaviour** (기반 추상 클래스)
   - 모든 ODCC 관련 클래스의 기반이 되는 추상 클래스입니다. Unity의 라이프사이클 메서드를 구현하고 ODCC 시스템 내에서 객체의 생명주기 관리에 사용됩니다.

3. **ContainerObject** (계층 구조 관리)
   - `ContainerNode`를 통해 오브젝트의 부모-자식 관계, 데이터, 컴포넌트를 관리하는 클래스입니다. 이 클래스는 객체 간의 계층 구조와 관련된 접근성을 제공합니다.

4. **ComponentBehaviour** (컴포넌트 클래스)
   - 각 `ObjectBehaviour`와 연관된 컴포넌트를 관리하며, 초기화, 유효성 검사, 폐기 작업을 수행합니다. 개별 기능을 담당하는 컴포넌트를 정의하고 관리하는 역할을 합니다.

5. **DataObject** (데이터 관리)
   - 오브젝트나 컴포넌트와 관련된 데이터를 저장하고 관리하는 클래스입니다. `Dispose()` 메서드를 통해 데이터의 정리 및 폐기를 처리합니다.

---

#### 사용 예제
[ProjectGroup-GamePlayer](https://github.com/B0ttle-Cat/ProjectGroup-GamePlayer/tree/master) 는 ODCC를 기반으로 만들어지고 있는 프로젝트 입니다. 
Assets/Scripts 에서 ODCC의 사용 방식을 확인해 보실 수 있습니다.
