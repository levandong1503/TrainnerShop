import type { ProductType } from './product-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateProductDto {
  name: string;
  description?: string;
  category: ProductType;
  price: number;
}

export interface ProductDto extends AuditedEntityDto<string> {
  name?: string;
  description?: string;
  category: ProductType;
  price: number;
}
