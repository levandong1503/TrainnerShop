import { mapEnumToOptions } from '@abp/ng.core';

export enum ProductType {
  RunningShoe = 0,
  Volleyball = 1,
  FootBall = 2,
  Normal = 3,
}

export const productTypeOptions = mapEnumToOptions(ProductType);
